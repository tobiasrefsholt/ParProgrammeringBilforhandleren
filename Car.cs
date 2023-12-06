namespace ParProgrammeringBilforhandleren;

public class Car
{
    private string _brand;
    public string _model;
    public int _year;
    public string _registration;
    public int _kilometers;

    public Car(string brand, string model, int year, string registration, int kilometers)
    {
        _brand = brand;
        _model = model;
        _year = year;
        _registration = registration;
        _kilometers = kilometers;
    }


    public void show()
    {
      Console.WriteLine($"brand: {_brand} modell: {_model} årsmodell: {_year} registreringsnummer: {_registration} kilometer: {_kilometers}");
    }


}