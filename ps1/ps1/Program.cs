//namespace PiterTicket
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите номер билета");
//            int ticket = int.Parse(Console.ReadLine());

//            int a = ticket % 10;
//            int b = ticket / 10 % 10;
//            int c = ticket / 100 % 10;
//            int d = ticket / 1000 % 10;
//            int e = ticket / 10000 % 10;
//            int f = ticket / 100000;

//            if (a + c + e == b + d + f)
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }
//}


//namespace Progressia
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("a0 = ");
//            double a = double.Parse(Console.ReadLine());

//            Console.Write("an = ");
//            double b = double.Parse(Console.ReadLine());

//            Console.Write("h = ");
//            double h = double.Parse(Console.ReadLine());

//            int n = (int)((b - a) / h + 1);
//            double sum = (a + b) / 2 * n;

//            n -= 2;
//            sum -= a + b;

//            Console.WriteLine($"Кол-во = {n}");
//            Console.WriteLine($"Сумма = {sum}");

//        }
//    }
//}




//namespace Pila
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("n = ");
//            int n = int.Parse(Console.ReadLine());

//            int a = int.Parse(Console.ReadLine());
//            bool up = false;
//            bool check = true;

//            for (int i = 1; i < n; i++)
//            {
//                int b = int.Parse(Console.ReadLine());
//                if (i == 1)
//                {
//                    if (b > a)
//                        up = true;
//                    else
//                        up = false;
//                }
//                else
//                {
//                    if (up && b > a)
//                        check = false;
//                    else if (!up && b < a)
//                        check = false;

//                    up = !up;
//                }

//                a = b;
//            }

//            if (check)
//                Console.WriteLine("YES");
//            else
//                Console.WriteLine("NO");
//        }
//    }
//}




//namespace BigDelitel
//{
//    internal class Program
//    {
//        static bool CheckPrime(long n)
//        {
//            for (int i = 2; i <= Math.Sqrt(n); i++)
//            {
//                if (n % i == 0)
//                    return false;
//            }
//            return true;
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите число");
//            long a = long.Parse(Console.ReadLine());

//            long i;
//            long result = 0;
//            for (i = 2; i <= Math.Sqrt(a); i++)
//            {
//                if (a % i == 0)
//                {
//                    if (CheckPrime(i))
//                    {
//                        result = i;
//                    }
//                    if (CheckPrime(a / i))
//                    {
//                        result = a / i;
//                        break;
//                    }
//                }
//            }

//            if (result == 0)
//            {
//                Console.WriteLine(a);
//            }
//            else
//            {
//                Console.WriteLine(result);
//            }
//        }
//    }
//}