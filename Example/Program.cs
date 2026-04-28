namespace Example;

static class Program

{
    static void Main(string[] args)
    {
        int[,] arraysA = new int[3, 3];
        int[,] arraysB = { { 1, 2 }, { 4, 5 }, { 7, 8 } };
        Console.WriteLine($"arraysB[0, 0] = {arraysB[0, 0]}");
        Console.WriteLine($"arraysB[0, 1] = {arraysB[0, 1]}");
        Console.WriteLine($"arraysB[0, 2] = {arraysB[0, 2]}");
        Console.WriteLine($"arraysB[1, 0] = {arraysB[1, 0]}");
        Console.WriteLine($"arraysB[1, 1] = {arraysB[1, 1]}");
        Console.WriteLine($"arraysB[1, 2] = {arraysB[1, 2]}");
        Console.WriteLine($"arraysB[2, 0] = {arraysB[2, 0]}");
        Console.WriteLine($"arraysB[2, 1] = {arraysB[2, 1]}");
        Console.WriteLine($"arraysB[2, 2] = {arraysB[2, 2]}");
    }
}
