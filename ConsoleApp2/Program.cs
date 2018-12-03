using System;
using System.Threading;
using System.Threading.Tasks;

namespace EnumHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose profession : ");
            Console.WriteLine("CEO       - 1 \nManager   - 2 \nDeveloper - 3");
            var choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter worked time : ");
            int wTime = Convert.ToInt32(Console.ReadLine());
            if (Accauntant.AskForBonus((Worker)choice, wTime)) Console.WriteLine("Bonus Earned!");
            else Console.WriteLine("Bonus not earned!");
        }
    }
    enum Worker
    {
        CEO = 1,
        Manager,
        Developer
    }
    struct Accauntant
    {
        public static bool AskForBonus(Worker tmp, int hours)
        {
            switch (tmp)
            {
                case Worker.CEO:
                    return hours > 190;
                case Worker.Manager:
                    return hours > 195;
                case Worker.Developer:
                    return hours > 200;
                default:
                    return false;
            }
        }
    }
}