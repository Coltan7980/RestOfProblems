using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestOfProblems
{
    internal class Methods
    {
        public static int FindMin(List<int> lyst)
        {
            int min = lyst[0];
            foreach (int i in lyst)
            {
                if (i < min)
                { min = i; }
            }
            return min;
        }
        public static int FindMax(List<int> lyst)
        {
            int max = lyst[0];
            foreach (int i in lyst)
            {
                if (i > max)
                { max = i; }
            }
            return max;
        }
        public static List<int> FindMinMax(List<int> lyst)
        {
            int min = Methods.FindMin(lyst);
            int max = Methods.FindMax(lyst);
            return new List<int> { min, max };
        }
        public static int GetAbsoluteSum(List<int> lyst)
        {
            int sum = 0;
            foreach (int i in lyst)
            {
                sum += Math.Abs(i); 
            }
            return sum;
        }
        public static List<int> MultiplyByLength(List<int> lyst)
        {
            for (int i = 0;  i < lyst.Count; i++)
            {
                lyst[i] *= lyst.Count;
            }
            return lyst;
        }
        public static string SmallerNum(int num1, int num2)
        {
            string Num1 = num1.ToString();
            string Num2 = num2.ToString();
            if (num1 <= num2)
            {
                return Num1;
            }
            else
            {
                return Num2;
            }
        }
        public static int WillOfD(string statement)
        {
            int numOfD = 0;
            for (int i = 0; i <= (statement.Length - 1); i++)
            {
                
                if (statement[i] == 'D' || statement[i] == 'd')
                {
                    numOfD += 1;
                }
            }
            return numOfD;
        }
    }
}
