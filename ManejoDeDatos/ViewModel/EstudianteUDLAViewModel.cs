using ManejoDeDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ManejoDeDatos.ViewModel
{
    public class EstudianteUDLAViewModel : INotifyPropertyChanged
    {
        private List<EstudianteUDLA> _estudiantesUDLA;
        public  List<EstudianteUDLA> estudianteUDLA
        {
            get => _estudiantesUDLA;
            set
            {
                if (estudianteUDLA != value)
                {
                    _estudiantesUDLA = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CommandGuardarEstudianteUDLA { get; set; }
        public EstudianteUDLAViewModel()
        {
            CommandGuardarEstudianteUDLA = new Command(GuardarEstudianteUDLA);
        }

        public void GuardarEstudianteUDLA(){ }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void RaisePropertyChanged(string propertyName) {
                
    }
}
