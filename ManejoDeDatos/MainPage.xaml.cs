using ManejoDeDatos.Interfaces;
using ManejoDeDatos.Models;
using ManejoDeDatos.Repositories;

namespace ManejoDeDatos
{
    public partial class MainPage : ContentPage
    {
        IEstudianteUDLARepository _estudianteUDLARepository;
        EstudianteUDLA estudiante = new EstudianteUDLA();
        public MainPage()
        {
            _estudianteUDLARepository = new EstudianteUDLAPorArchivosRepository();
            InitializeComponent();

            estudiante = _estudianteUDLARepository.GetEstudianteUDLA(1);
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
