namespace Ex_02_08;

static class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        string[] stations = { "品川", "大崎", "五反田", "目黒", "恵比寿", "渋谷", "原宿", "代々木", "新宿" };
        while (i < stations.Length)
        {
            Console.WriteLine(stations[i++]);
        }
    }
}
