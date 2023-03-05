namespace BridgePattern.Models
{
    public class SonyRemoteControl : RemoteControl
    {
        public SonyRemoteControl(Device device) : base(device)
        {
        }

        public override void TurnOn()
        {
            Console.WriteLine("Sony " + Device.GetType().Name.ToLower() + " is on.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Sony " + Device.GetType().Name.ToLower() + " is off.");
        }
    }
}