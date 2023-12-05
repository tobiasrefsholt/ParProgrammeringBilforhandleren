// See https://aka.ms/new-console-template for more information

using ParProgrammeringBilforhandleren;

var store = new Store();
store.AddCar(new Car("Ferrari","250GTO", 2024, "BTC999", 10));
store.AddCar(new Car("Audi", "RS7", 2024, "LS99911", 10));
store.AddCar(new Car("BMW", "M2", 2024, "BMWM2", 10));

while (true)
{
    Console.Write("\nVelkommen! Velg fra menyen: ");
    var input = Console.ReadKey().KeyChar;
    Console.WriteLine();
    switch (input)
    {
        case '1':
            Console.WriteLine("Legg til ny bil");
            break;
    }
}