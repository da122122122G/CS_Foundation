using System.ComponentModel.DataAnnotations;
using Ex_03_11.Modules;

namespace Ex_03_11;

static class Program
{
    static void Main(string[] args)
    {
        var flashMemory = new FlashMemory();
        var mouse = new Mouse();
        var display = new Display();

        flashMemory.SendData();
        flashMemory.ReciveData();
        mouse.SendData();
        display.ReciveData();

    }
}
