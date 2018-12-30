using System;

namespace DesignPatterns.Command.RemoteControl.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var light = new Light();

            var ligthOffCommand = new LightOffCommand(light);
            var ligthOnCommand = new LightOnCommand(light);

            var stereo = new Stereo();

            var stereoOnWithCdCommand = new StereoOnWithCdCommand(stereo);
            var stereoOffCommand = new StereoOffCommand(stereo);

            var remoteControl = new RemoteControl();
            remoteControl.SetCommand(0, ligthOnCommand, ligthOffCommand);
            remoteControl.SetCommand(1, stereoOnWithCdCommand, stereoOffCommand);
            
            System.Console.WriteLine(remoteControl.ToString());

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();
            System.Console.ReadKey();
        }
    }
}
