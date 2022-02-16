using System;
public interface IFactory
{
    void Drive(int miles);
}
public class Scooter : IFactory
{
    public void Drive(int miles)
    {
        Console.WriteLine("Drive the scooter : " + miles.ToString() + " miles");
    }
}
public class Bike : IFactory
{
    public void Drive(int miles)
    {
        Console.WriteLine("Drive the bike : " + miles.ToString() + " miles");
    }
}
public abstract class VehicleFactory
{
    public abstract IFactory GetVehicle(string vehicle);
}
public class ConcreteVehicleFactory : VehicleFactory
{
    public override IFactory GetVehicle(string vehicle)
    {
        switch(vehicle)
        {
            case "Scooter" : return new Scooter();
            case "Bike" : return new Bike();
            default : throw new ApplicationException("Vehicle cannot be created");
        }
    }
}
public class Test
{
	public static void Main()
	{
		// your code goes here
		ConcreteVehicleFactory factory = new ConcreteVehicleFactory();
		IFactory scooter = factory.GetVehicle("Scooter");
		scooter.Drive(10);
		IFactory bike = factory.GetVehicle("Bike");
		bike.Drive(20);
	}
}
