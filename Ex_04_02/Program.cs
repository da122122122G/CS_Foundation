namespace Ex_04_02;

static class Program
{
    static void Main(string[] args)
    {


        Console.Write("年を入力してください->");

        int year1 = int.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year1) == true)
        {
            Console.WriteLine(year1 + "年は閏年です。");
        }
        else
        {
            Console.WriteLine(year1 + "年は閏年ではありません。");
        }


    }
}
