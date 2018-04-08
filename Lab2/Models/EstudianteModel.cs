using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace Lab2.Models
{
    public class EstudianteModel
    {

        public EstudianteModel()
        {
        }


        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Nota{ get; set; }
        public string Foto { get; set; }

        public List<TareasModel> lstTareas = new List<TareasModel>();



        public static async Task<ObservableCollection<EstudianteModel>> ObtenerEstudiantes(){
            ObservableCollection<EstudianteModel> lstEstudiantes = new ObservableCollection<EstudianteModel>();


            lstEstudiantes.Add(new EstudianteModel { ID = 1, Nombre = "Carla Cinture", Nota = 60 });
            lstEstudiantes.Add(new EstudianteModel { ID = 1, Nombre = "Carlos Dano", Nota = 60 });
            lstEstudiantes.Add(new EstudianteModel { ID = 1, Nombre = "Gabriel Solis", Nota = 60 });
            lstEstudiantes.Add(new EstudianteModel { ID = 1, Nombre = "Giancarlo Lulo", Nota = 60 });

            Task.Delay(1000);

            return lstEstudiantes;

        }







    }
}
