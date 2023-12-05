namespace ParProgrammeringBilforhandleren;

public class Car
{
    private string _brand;
    private string _model;
    private int _year;
    private string _registration;
    private int _kilometers;

    public Car(string brand, string model, int year, string registration, int kilometers)
    {
        _brand = brand;
        _model = model;
        _year = year;
        _registration = registration;
        _kilometers = kilometers;
    }
}