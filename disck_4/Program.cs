using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disck_4
{
    class Program
    {
        static void printer(double[,] arr, ref string output)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    output += $"{arr[i, j]} ";
                output += "\n";
            }
        }
        static void Main(string[] args)
        {
            double n = 9, a = 98, b = 56;
            string output = "";
            double g, h;

            double[,] d = new double[9, 9];
            double[,] m = new double[9, 9];

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if ((i+1) + (j+1) < n) d[i, j] = (i+1) + (j+1);
                    else d[i, j] = i+1 + j+1 - n;
                }
            d[8, 8] = 0;
            printer(d, ref output);
            output += "\n";

            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    if ((i+1) * (j+1) < n) m[i, j] = (i+1) * (j+1);
                    else
                    {
                        double buf = (i + 1) * (j + 1) - n ;
                        while (buf >= n)
                        {
                            buf -= n;    
                        }
                        m[i, j] = buf;
                    }
                }
            printer(m, ref output);
            output += "\n";

            double bg = a + b;
            while (bg >= n)
            {
                bg -= n;
            }
            g = bg;

            double bh = a * b;
            while (bh >= n)
            {
                bh -= n;
            }
            h = bh;

            output += $"A+B = {g} \nA*B = {h}";

            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
