namespace BridgePattern.Models
{
    public class PanasonicRemoteControl : RemoteControl
    {
        public PanasonicRemoteControl(Device device) : base(device)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine("Panasonic " + Device.GetType().Name.ToLower() + " is on.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Panasonic " + Device.GetType().Name.ToLower() + " is off.");
        }
    }
}