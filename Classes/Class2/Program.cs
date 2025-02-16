public class Device
{
    public string Name { get; set; }
    public bool IsOn { get; set; }

    public Device(string name)
    {
        Name = name;
        IsOn = false;
    }

    public void TurnOn()
    {
        IsOn = true;
    }

    public void TurnOff()
    {
        IsOn = false;
    }
}

public class SmartHomeSystem
{
    private List<Device> devices;

    public SmartHomeSystem()
    {
        devices = new List<Device>();
    }

    public void AddDevice(string name)
    {
        devices.Add(new Device(name));
    }

    public void RemoveDevice(string name)
    {
        devices.RemoveAll(d => d.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void TurnOnAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOn();
        }
    }

    public void TurnOffAllDevices()
    {
        foreach (var device in devices)
        {
            device.TurnOff();
        }
    }

    public void DisplayDevices()
    {
        foreach (var device in devices)
        {
            Console.WriteLine($"Device: {device.Name}, Status: {(device.IsOn ? "On" : "Off")}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SmartHomeSystem home = new SmartHomeSystem();

        home.AddDevice("Living Room Light");
        home.AddDevice("Thermostat");
        home.AddDevice("Security Camera");

        Console.WriteLine("Initial Device Status:");
        home.DisplayDevices();

        home.TurnOnAllDevices();
        Console.WriteLine("\nAfter Turning On All Devices:");
        home.DisplayDevices();

        home.RemoveDevice("Thermostat");
        Console.WriteLine("\nAfter Removing Thermostat:");
        home.DisplayDevices();
    }
}
