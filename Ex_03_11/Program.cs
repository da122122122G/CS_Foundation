using System.ComponentModel.DataAnnotations;
using Ex_03_11.Modules;

namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        IUSB usb1 = new FlashMemory();
        usb1.SendData();
        usb1.ReciveData();

        usb1 = new Mouse();
        usb1.SendData();

        usb1 = new Display();
        usb1.ReciveData();

    }
}
