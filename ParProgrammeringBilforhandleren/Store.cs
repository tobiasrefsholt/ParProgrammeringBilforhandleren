namespace ParProgrammeringBilforhandleren;

public class Store
{
    private readonly List<Car> _carsForSale = new();

    public void AddCar(Car car)
    {
        _carsForSale.Add(car);
    }
}