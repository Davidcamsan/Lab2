using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using Xamarin.Forms;
using Lab2.Models;


namespace Lab2.ViewModels
{
    public class EstudianteViewModel : INotifyPropertyChanged
    {
        #region Singleton
        private static EstudianteViewModel instance = null;

        public EstudianteViewModel()
        {
            InitClass();
            InitCommands();
        }

        public static EstudianteViewModel GetInstance()
        {
            if (instance == null)
            {
                instance = new EstudianteViewModel();
            }

            return instance;
        }

        public static void DeleteInstance()
        {
            if (instance != null)
            {
                instance = null;
            }
        }
        #endregion


        #region Instancias
        private EstudianteModel _EstudianteActual { get; set; }

        public EstudianteModel EstudianteActual
        {
            get
            {
                return _EstudianteActual;
            }

            set
            {
                _EstudianteActual = value;
                OnPropertyChanged("EstudianteActual");
            }
        }

        private ObservableCollection<EstudianteModel> _lstEstudiantes = new ObservableCollection<EstudianteModel>();

        public ObservableCollection<EstudianteModel> lstEstudiantes
        {
            get
            {
                return _lstEstudiantes;
            }

            set
            {
                _lstEstudiantes = value;
                OnPropertyChanged("lstEstudiantes");
            }
        }

        public ICommand VerEstudianteCommand { get; set; }
        public ICommand AgregarEstudianteCommand { get; set; }

        #endregion

        #region Methods
        private void VerEstudiante(int id){
            EstudianteActual = lstEstudiantes.Where(x => x.ID == id).FirstOrDefault();

        }

        private void AgregarEstudiante(){
            GetInstance().lstEstudiantes.Add(EstudianteActual);
            EstudianteActual = null;
        }





        private async void InitClass()
        {
            lstEstudiantes = await EstudianteModel.ObtenerEstudiantes();
        }

        private void InitCommands()
        {
            VerEstudianteCommand = new Command<int>(VerEstudiante);
            AgregarEstudianteCommand = new Command(AgregarEstudiante);
        }

         #endregion




        #region INotifyPropertyChanged Interface

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (propertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion






    }
}
