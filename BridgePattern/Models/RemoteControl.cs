namespace BridgePattern.Models
{
    public abstract class RemoteControl
    {
        public Device Device { get; set; }
        public RemoteControl(Device device)
        {
            Device = device;
        }
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}