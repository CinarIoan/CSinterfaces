using System;

namespace csinterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 180);
            Vehicle dacia = new Vehicle("Dacia");
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else Console.WriteLine("The {0} can't be driven.", buick.Brand);

            if (dacia is IDrivable)
            {
                dacia.Move();
                dacia.Stop();
            }
            else Console.WriteLine("The {0} can't be driven.", dacia.Brand);

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButtoon powBut = new PowerButtoon(TV);
            powBut.Execute();
            powBut.Undo();
            TV.VolumeUp();
            TV.VolumeDown();
        }
    }
}
