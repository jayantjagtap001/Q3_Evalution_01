

class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("The vehicle is driving.");
    }
}

class ElectricVehicle : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("This is ElectricVehicle vehical ");
    }
}

class GasPoweredVehicle :Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("This is GasPoweredVehicle vehical");
    }
}

class SelfDrivingCar : ElectricVehicle
{
    public override void Drive()
    {
        Console.WriteLine("This is SelfDrivingCar vehical");
    }
}

class HybridCar : GasPoweredVehicle
{
    public override void Drive()
    {
        Console.WriteLine("This is HybridCar vehical");
    }
}

class SmartVehicleSystem
{
    public static void Main(string[] args)
    {
        Vehicle basicVehicle = new Vehicle();
        basicVehicle.Drive();

        ElectricVehicle ev = new ElectricVehicle();
        ev.Drive();

        GasPoweredVehicle gas = new GasPoweredVehicle();
        gas.Drive();

        SelfDrivingCar selfDriving = new SelfDrivingCar();
        selfDriving.Drive();

        HybridCar hybrid = new HybridCar();
        hybrid.Drive();

    }
}
