namespace RestOfProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lyst = new List<int>() { -3,-2,-1,0,1,2};
            foreach (int i in Methods.FindMinMax(lyst))
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");
            Console.WriteLine(Methods.GetAbsoluteSum(lyst));
            Console.WriteLine(Methods.SmallerNum(5,6));
            Console.WriteLine(Methods.WillOfD("d is a D word with d in it"));
            
            foreach (int i in Methods.MultiplyByLength(lyst))
            {
                Console.Write(i + " ");
            }
        }
        
    }
}
