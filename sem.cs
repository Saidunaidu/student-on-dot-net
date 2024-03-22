u

namespace program
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            String name, Rollno;
            int s1, s2, s3, s4, s5;
            Console.Write("Name          : ");
            name = Console.ReadLine();
            Console.WriteLine()
            Rollno = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(" ---------- 3-2 Sem ----------     ");
            Console.WriteLine();
            Console.Write("Subject1      : ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Subject2      : ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Subject3      : ");
            s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Subject4      : ");
            s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Subject5      : ");
            s5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double total = s1 + s2 + s3 + s4 + s5;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("TOTAL         : " + total);
            Console.WriteLine();
            Console.WriteLine("percentage    : " + (total / 500) * 100 + "%");

        }
    }
}
