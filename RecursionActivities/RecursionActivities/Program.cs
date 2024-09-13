namespace RecursionActivities
{
    internal class Program
    {
        static int s = 3;
        static Dictionary<int, long> dic = new();
        static List<string> words = new();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //MyFibonacci(2, 0, 1, 0);
            //Console.WriteLine("Eb version is: " + EbFibonacci(s));
            Console.WriteLine("Unique steps: " + ClimbStairs(s));
        }

        //public static string StringPermutation(string word)
        //{
        //    if (word.Length == 1)
        //    {
        //        return word;
        //    }
        //    if (!words.Contains(word)) 
        //    { 
                
        //    }
        //    else
        //    {
                
        //    }
        //}

        public static long ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            return ClimbStairs(n -1) + ClimbStairs(n - 2);
        }

        public static void MyFibonacci(int i, long a, long b, long sum)
        {
            if (i <= s)
            {
                sum = a + b;
                a = b;
                b = sum;
                i++;
                MyFibonacci(i, a, b, sum);
            }
            else
            {
                Console.WriteLine("My version is:" + sum);
            }
        }

        public static long EbFibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                dic[n] = 1;
                return 1;
            }
            else if (dic.ContainsKey(n))
            {
                return dic[n];
            }
            else
            {
                long num = EbFibonacci(n - 1) + EbFibonacci(n - 2);
                dic[n] = num;
                return num;
            }
        }
    }
}
