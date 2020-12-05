using System;
namespace csinterfaces
{
    class PowerButtoon : ICommand
    {
        IElectronicDevice device;

        public PowerButtoon(IElectronicDevice aDevice)
        {
            device = aDevice;
        }
        public void Execute()
        {
            device.On();
        }
        public void Undo()
        {
            device.Off();
        }
    }
}