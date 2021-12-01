using System;

namespace LineComparisonUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Line");
            Console.Write("Enter the Co-rdinate X1: ");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate Y1: ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate X2: ");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate Y2: ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second Line");
            Console.Write("Enter the Co-rdinate A1: ");
            int A1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate B1: ");
            int B1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate A2: ");
            int A2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Co-rdinate B2: ");
            int B2 = Convert.ToInt32(Console.ReadLine());

            double PowofpointsX = Math.Pow(2, (X2 - X1));
            double PowofpointsY = Math.Pow(2, (Y2 - Y1));
            double LengthofLine1 = Math.Sqrt((PowofpointsX + PowofpointsY));
            Console.WriteLine("Length of the Line 1 is: " + LengthofLine1);

            double PowofpointsA = Math.Pow(2, (A2 - A1));
            double PowofpointsB = Math.Pow(2, (B2 - B1));
            double LengthofLine2 = Math.Sqrt((PowofpointsA + PowofpointsB));
            Console.WriteLine("Length of the Line 2 is: " + LengthofLine2);

            Console.WriteLine(LengthofLine1.Equals(LengthofLine2));
            if (LengthofLine1.Equals(LengthofLine2) == true)
                Console.WriteLine("Both lines are Equal");
            if (LengthofLine1.Equals(LengthofLine2) == false)
                Console.WriteLine("Both lines are not Equal");
            Console.WriteLine(LengthofLine1.CompareTo(LengthofLine2));
            if(LengthofLine1.CompareTo(LengthofLine2)==1)
                Console.WriteLine("Line 1 is Bigger than Line2");
            if (LengthofLine1.CompareTo(LengthofLine2) == -1)
                Console.WriteLine("Line 1 is Smaller than Line2");
            if (LengthofLine1.CompareTo(LengthofLine2) == 0)
                Console.WriteLine("Line 1 is Equal to Line2");
            Console.ReadLine();
        }
    }
}
