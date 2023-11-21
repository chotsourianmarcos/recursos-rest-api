// See https://aka.ms/new-console-template for more information
using ConsoleApp.Services;
using Entities.Items;

var patients = new List<Patient>();

Console.WriteLine("Bienvenid@ al Admin Veterinaria!");

MenuService.ShowMenu();
var selectedOption = Convert.ToInt16(Console.ReadLine());

while(selectedOption != 0){
    switch(selectedOption){
        case 1:
            var newPatient = MenuService.CreatePatient();
            patients.Add(newPatient);
            break;
        case 2:
            MenuService.PrintPatientList(patients);
            Console.ReadLine();
            break;
        case 3:
            break;
        case 0:
            selectedOption = 0;
            break;
        default:
            break;
    }
    if(selectedOption != 0){
    MenuService.ShowMenu();
    selectedOption = Convert.ToInt16(Console.ReadLine());
    }
}
Console.WriteLine("Hasta pronto!");


//Tipo de "algo": MenuService