using Entities.Items;

namespace ConsoleApp.Services {
    public static class MenuService{
        public static void ShowMenu(){
            Console.Clear();
            Console.WriteLine("1. Ingrese nuevo paciente.");
            Console.WriteLine("2. Listar pacientes.");
            Console.WriteLine("3. Modificar paciente.");
            Console.WriteLine("0. Salir.");
        }
        public static Patient CreatePatient(){
            Console.WriteLine("Ingrese el nombre del paciente");
            var patientName = Console.ReadLine();
            Console.WriteLine("Ingrese la especie del paciente");
            var patientSpecies = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del paciente");
            int patientAge = Convert.ToInt16(Console.ReadLine());
            var newPatient = new Patient(patientName, patientSpecies, patientAge);
            return newPatient;
        }

        public static void PrintPatientList(List<Patient> patients){
            foreach(var p in patients){
                Console.WriteLine(p.Name + " - " + p.Species + " - Edad: " + p.Age);
            }
        }
    }
}

//paciente
//consulta