using System.Security.Cryptography.X509Certificates;

namespace ParProgrammeringBilforhandleren;

public class Store
{
    private readonly List<Car> _carsForSale = new();

    public void AddCar(Car car)
    {
        _carsForSale.Add(car);
    }

    public void AvailableCars()
    {
        foreach (Car car in _carsForSale)
        {
            car.show();
        }
    }

    public void DisplayCarByYear(int intYear, int intyearMin)
    {
        var filteredCars = _carsForSale.Where(car => car._year <= intYear && car._year >= intyearMin);
        foreach (var car in filteredCars)
        {
            car.show();
        }
    }

    public void DisplayCarByKm(int intkm, int minKm)
    {
        var filteredCars = _carsForSale.Where(car => car._kilometers <= intkm && car._kilometers >= minKm);
        foreach (var car in filteredCars)
        {
            car.show();
        }
    }

    public Car OrderedCar(string registration)
    {
        var orderedCar = _carsForSale.Find(car => car._registration == registration);
        orderedCar?.show();
        Console.WriteLine("Gratulerer med ny bil! :) ");
        _carsForSale.Remove(orderedCar);
        return orderedCar;
    }
}