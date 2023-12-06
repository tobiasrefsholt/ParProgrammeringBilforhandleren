// See https://aka.ms/new-console-template for more information

using ParProgrammeringBilforhandleren;

var store = new Store();
store.AddCar(new Car("Ferrari","250GTO", 2024, "BTC999", 10));
store.AddCar(new Car("Audi", "RS7", 2024, "LS99911", 10));
store.AddCar(new Car("BMW", "M2", 2015, "BMWM2", 2));

var CustomerCars = new List<Car>();

while (true)
{
    Console.WriteLine("1. Vis tilgjengelige biler");
    Console.WriteLine("2. finn en bil ut fra årsrange");
    Console.WriteLine("3. finn bil ut ifra kilometerstand");
    Console.WriteLine("4. kjøp bil");
    Console.WriteLine("5. vis dine biler");
    Console.Write("\nVelkommen! Velg fra menyen: ");
    var input = Console.ReadKey().KeyChar;
    Console.WriteLine();

    switch (input)
    {
        case '1':
            store.AvailableCars();
            break;
        case '2':
            Console.WriteLine("skriv inn max år");
            var inputMaxYear = Console.ReadLine();
            int intYear = Int32.Parse(inputMaxYear);
            Console.WriteLine("skriv inn min år");
            int intyearMin = Int32.Parse(Console.ReadLine());
            store.DisplayCarByYear(intYear, intyearMin);
            break;
        case '3':
            Console.WriteLine("skriv inn max km");
            var inputMaxKm = Console.ReadLine();
            int intkm = Int32.Parse(inputMaxKm);
            Console.WriteLine("skriv inn min km");
            var inputkm = Console.ReadLine();
            int intMinKm = Int32.Parse(inputkm);
            store.DisplayCarByKm(intkm, intMinKm);
            break;
        case '4':
            Console.WriteLine("Skriv inn registreringsnummer på bil");
            var kjøp = Console.ReadLine();
            var Kjøptbil = store.OrderedCar(kjøp);
            CustomerCars.Add(Kjøptbil);
            break;
        case '5':
            foreach (var car in CustomerCars)
            {
                Console.WriteLine("Dine biler:");
                car.show();
            }
            break;
    }
}


/*
En bilforhandler har ulike biler i shappa si, det kan være biler med ulike merker, årsmodell, 
registreringsnummer og kilometerstand.
Når kunden kommer inn i shappa skal han kunne se hvilke biler som finnes i shappa, 
eller han kan velge å finne en bil ut fra årsrange, eller en bil som har kjørt mer eller mindre enn en gitt kilometerstand.
Kunden skal også ha mulighet til å kjøpe en av bilene. Bilen må da tilhøre kunden og ikke forhandleren.
 */