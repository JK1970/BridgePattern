using BridgePattern.Models;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            TV tV = new();
            SonyRemoteControl sonyRemoteControl = new(tV);

            sonyRemoteControl.TurnOn();

            Radio radio = new();
            PanasonicRemoteControl panasonicRemoteControl = new(radio);

            panasonicRemoteControl.TurnOff();
        }
    }
}

