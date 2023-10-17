using extensions.Extensions;

namespace extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                           BEST OPTIMAL CODE");
            Console.WriteLine("\n\n");
            Console.WriteLine("========task1=========");
            string task = "Salam BB206, necəsiniz BB206 əhli ";
            Console.WriteLine(task.Repeated("BB206"));
            Console.WriteLine("\n\n\n");


            Console.WriteLine("========task2=========");
            int num = 1221;
            Console.WriteLine( num.IsPolendrom() );
            Console.WriteLine("\n\n\n");


            Console.WriteLine("========task3=========");
            string word = "eccghcf 4fcfgc";
            Console.WriteLine(word.HasAnyDigit() );
            Console.WriteLine("\n\n");
            
        }
    }
}