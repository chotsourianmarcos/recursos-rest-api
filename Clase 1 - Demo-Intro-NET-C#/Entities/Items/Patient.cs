namespace Entities.Items {
    public class Patient {
        public Patient(){
            Carers = new List<string>();
        }
        public Patient(string name, string species, int age){
            Name = name;
            Species = species;
            Age = age;
            Carers = new List<string>();
        }
        public string Name { get; set; } = "";
        public string Species { get; set; } = "";
        public int Age { get; set; }
        public List<string> Carers { get; set; }
    }
}