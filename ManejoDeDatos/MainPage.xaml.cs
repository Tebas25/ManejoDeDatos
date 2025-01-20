using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using ManejoDeDatos.Repositories;
using System.Collections.ObjectModel;

namespace ManejoDeDatos
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUDLARepository _estudianteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();
        ObservableCollection<EstudianteUDLA> _estudiantes = new ObservableCollection<EstudianteUDLA>();
        public MainPage()
        {
            _estudianteUDLARepository = new EstudianteUDLASQLiteRepository();
            InitializeComponent();

            var estudiantesUDLA = _estudianteUDLARepository.GetListEstudianteUDLA().ToList();
            BindingContext = estudiante;
        }

        private async void GuardarEstudiante_Clicked(object sender, EventArgs e)
        {
            EstudianteUDLA estudiante = new EstudianteUDLA{
                ID = 1,
                Nombre = "Sebastián",
                Carrera = "Ingeniería de Software"
            };
            bool guardar_estudiante = _estudianteUDLARepository.CreateEstudianteUDLA(estudiante);
            
            if (guardar_estudiante){
                await DisplayAlert("ALERTA", "Todo Posi", "OK");
            }else{
                await DisplayAlert("ALERTA", "Negado mi pana", "OK");
            }
        }
    }

}
