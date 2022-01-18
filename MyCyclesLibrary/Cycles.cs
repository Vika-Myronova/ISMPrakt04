using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCyclesLibrary
{
    public class Cycles
    {
        public static int For1(int a, int b)
        {
            int dob = 1;
            for (int i = a; i <= b; i++)
                dob *= i;
            return dob;
        }
        public static double For2(int n)
        {
            int a;
            double summa = 0;
            for (int i = 1; i <= n; i++)
            {
                a = i;
                summa += 1.0 / a;
            }
            return summa;
        }
        public static double For3(double a, int n)
        {
            double pow = 1;
            for (int i = 1; i <= n; i++)
                pow *= a;
            return pow;
        }
        public static int For4(int a, int b)
        {
            int summ = 0;
            for (int i = a; i <= b; i++)
            {
                int n = i;
                n = (int)Math.Pow(n, 2);
                summ += n;
            }
            return summ;
        }
        public static int factorial(int n)
        {
            int factorial = 1;
            if (n == 1)
                return 1;
            else if (n < 0)
                return -1;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial *= i;
                }
                return factorial;
            }
        }
        public static int For5(int n)
        {
            int res = 0;
            for (int i = 1; i <= n; i++)
                res += factorial(i);
            return res;
        }
        public static int While1(int n)
        {
            int k = 1, res = 0;
            while (n != 0)
            {
                res += (int)Math.Pow(k, n);
                k++;
                n--;
            }
            return res;
        }
        public static int While2(int n)
        {
            int k = 1, m = 0;
            double p = 0;
            while (p <= n)
            {
                p = Math.Pow(3, k);
                m = k;
                k++;
            }
            return m;
        }
        public static void While3(ref int p, ref int day, double l, ref double sum)
        {
            while (sum < 200)
            {
                double d = l * p / 100;
                l = l + d;
                sum += l;
                day++;
            }
        }

    }
}
