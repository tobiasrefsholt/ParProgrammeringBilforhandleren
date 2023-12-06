using System.Security.Cryptography.X509Certificates;

namespace ParProgrammeringBilforhandleren;

public class Store
{
    public readonly List<Car> _carsForSale = new();

    public void AddCar(Car car)
    {
        _carsForSale.Add(car);
    }

    public void avaiablecars()
    {
        foreach (Car car in _carsForSale)
        {
            car.show();

        }
    }
    public void displaycarbyYear(int intYear, int intyearMin)
    {
        var filteredCars = _carsForSale.Where(car => car._year <= intYear && car._year >= intyearMin);
        foreach (var car in filteredCars)
        {
            car.show();
        }
    }

    public void displaycarbyKm(int intkm, int minKm)
    {
        var filteredCars = _carsForSale.Where(car => car._kilometers <= intkm && car._kilometers >= minKm);
        foreach (var car in filteredCars)
        {
            car.show();
        }
    }

    public Car bestiltbil(string kjøp)
    {
        var filteredCars = _carsForSale.Find(car => car._registration == kjøp);
        filteredCars.show();
        Console.WriteLine("Gratulerer med ny bil! :) ");
        _carsForSale.Remove(filteredCars);
        return filteredCars;
    }




}