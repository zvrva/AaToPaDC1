using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


class Task1
{
    public static void ChangeMatrix1(int[,] a, int N)
    {
        for (int j = 0; j < N; j++)
        {
            for (int i = 0; i < N; i++)
            {
                a[j, i] = i / (j + 1);
            }
        }
    }


    public static void ChangeMatrix2(int[,] a, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                a[j, i] = i / (j + 1);
            }
        }
    }



    public static void ChangeMatrix3(int[,] a, int N)
    {
        for (int i = N - 1; i > 0; i--)
        {
            for (int j = N - 1; j > 0; j--)
            {
                a[i, j] = i / (j + 1);
            }
        }
    }


    public static void ChangeMatrix4(int[,] a, int N)
    {
        for (int j = N - 1; j > 0; j--)
        {
            for (int i = N - 1; i > 0; i--)
            {
                a[j, i] = i / (j + 1);
            }
        }
    }



    public static void Run ()
    {
        int N = 6000;
        int M = 1000;

        int s = 0;
        int[,] a = new int[N, N];
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                a[i, j] = s;
                s++;
            }
        }


        List<double> times1 = new List<double>();
        for (int i = 0; i < M; i++)
        {
            DateTime t1 = DateTime.Now;
            ChangeMatrix1(a, N);
            DateTime t2 = DateTime.Now;
            TimeSpan dt = t2 - t1;
            times1.Add(dt.TotalMilliseconds);
        }
        Console.WriteLine($"{times1.Max()} {times1.Min()} {times1.Average()}");



        List<double> times2 = new List<double>();
        for (int i = 0; i < M; i++)
        {
            DateTime t1 = DateTime.Now;
            ChangeMatrix2(a, N);
            DateTime t2 = DateTime.Now;
            TimeSpan dt = t2 - t1;
            times2.Add(dt.TotalMilliseconds);
        }
        Console.WriteLine($"{times2.Max()} {times2.Min()} {times2.Average()}");



        List<double> times3 = new List<double>();
        for (int i = 0; i < M; i++)
        {
            DateTime t1 = DateTime.Now;
            ChangeMatrix3(a, N);
            DateTime t2 = DateTime.Now;
            TimeSpan dt = t2 - t1;
            times3.Add(dt.TotalMilliseconds);
        }
        Console.WriteLine($"{times3.Max()} {times3.Min()} {times3.Average()}");



        List<double> times4 = new List<double>();
        for (int i = 0; i < M; i++)
        {
            DateTime t1 = DateTime.Now;
            ChangeMatrix4(a, N);
            DateTime t2 = DateTime.Now;
            TimeSpan dt = t2 - t1;
            times4.Add(dt.TotalMilliseconds);
        }
        Console.WriteLine($"{times4.Max()} {times4.Min()} {times4.Average()}");        
    }
}


class Task2
{
    public static void ChangeMatrix1(int[,] a, int N)
    {
        for (int j = 0; j < N; j++)
        {
            for (int i = 0; i < N; i++)
            {
                a[j, i] = i / (j + 1);
            }
        }
    }


    public static void ChangeMatrix2(int[,] a, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                a[j, i] = i / (j + 1);
            }
        }
    }



    public static void ChangeMatrix3(int[,] a, int N)
    {
        for (int i = N - 1; i > 0; i--)
        {
            for (int j = N - 1; j > 0; j--)
            {
                a[i, j] = i / (j + 1);
            }
        }
    }


    public static void ChangeMatrix4(int[,] a, int N)
    {
        for (int j = N - 1; j > 0; j--)
        {
            for (int i = N - 1; i > 0; i--)
            {
                a[j, i] = i / (j + 1);
            }
        }
    }


    public static void Run()
    {
        int M = 10;

        for (int N = 10; N < 10011; N += 2000)
        {
            int s = 0;
            int[,] a = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    a[i, j] = s;
                    s++;
                }
            }
            Console.WriteLine($"N={N}");

            List<double> times1 = new List<double>();
            for (int i = 0; i < M; i++)
            {
                DateTime t1 = DateTime.Now;
                ChangeMatrix1(a, N);
                DateTime t2 = DateTime.Now;
                TimeSpan dt = t2 - t1;
                times1.Add(dt.TotalMilliseconds);
            }
            Console.WriteLine(times1.Average());



            List<double> times2 = new List<double>();
            for (int i = 0; i < M; i++)
            {
                DateTime t1 = DateTime.Now;
                ChangeMatrix2(a, N);
                DateTime t2 = DateTime.Now;
                TimeSpan dt = t2 - t1;
                times2.Add(dt.TotalMilliseconds);
            }
            Console.WriteLine(times2.Average());



            List<double> times3 = new List<double>();
            for (int i = 0; i < M; i++)
            {
                DateTime t1 = DateTime.Now;
                ChangeMatrix3(a, N);
                DateTime t2 = DateTime.Now;
                TimeSpan dt = t2 - t1;
                times3.Add(dt.TotalMilliseconds);
            }
            Console.WriteLine(times3.Average());



            List<double> times4 = new List<double>();
            for (int i = 0; i < M; i++)
            {
                DateTime t1 = DateTime.Now;
                ChangeMatrix4(a, N);
                DateTime t2 = DateTime.Now;
                TimeSpan dt = t2 - t1;
                times4.Add(dt.TotalMilliseconds);
            }
            Console.WriteLine(times4.Average());
            Console.WriteLine("\n");
        }
    }
}


class Task3
{
    static void Print()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
    public static void Run()
    {
        int[] NS = { 1000, 5000, 10000, 15000, 20000 };
        int[] MS = { 1, 2, 4, 8, 12, 16, 20 };

        foreach (int n in NS)
        {
            foreach (int m in MS)
            {
                Console.WriteLine($"N = {n}, M = {m}");
                //Создание массива А
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = i;
                }

                //Заполнение последовательно
                double[] b = new double[n];
                DateTime d1 = DateTime.Now;
                for (int i = 0; i < n; i++)
                {
                    double s = 0;
                    for (int j = 0; j < i; j++)
                    {
                        s += Math.Pow(a[i], 1.789);
                    }
                    b[i] = s;
                }
                DateTime d2 = DateTime.Now;
                var d = (d2 - d1).TotalMilliseconds;
                Console.WriteLine($"Time: {d} msc");

                //Заполнение параллельно
                double[] bp = new double[n];
                Thread[] threads = new Thread[m];
                DateTime dp1 = DateTime.Now;
                for (int i = 0; i < m; i++)
                {
                    int start = n / m * i, end = n / m * (i + 1);
                    threads[i] = new Thread(() =>
                    {
                        int actions = 0;
                        for (int j = start; j < end; j++)
                        {
                            double s = 0;
                            for (int k = 0; k < j; k++)
                            {
                                s += Math.Pow(a[k], 1.789);
                                actions++;
                            }
                            bp[j] = s;
                        }
                        Console.WriteLine($"Potok: {i}, actions = {actions}");
                    });
                    threads[i].Start();
                }
                for (int i = 0; i < m; i++)
                {
                    threads[i].Join();
                }
                DateTime dp2 = DateTime.Now;
                var dp = (dp2 - dp1).TotalMilliseconds;
                Console.WriteLine($"Time: {dp} msc");
            }
        }
    }
}


class Task4
{
    static void Print()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
    public static void Run()
    {
        int[] NS = { 1000, 5000, 10000, 15000, 20000 };
        int[] MS = { 1, 2, 4, 8, 12, 16, 20 };

        foreach (int n in NS)
        {
            foreach (int m in MS)
            {
                Console.WriteLine($"N = {n}, M = {m}");
                //Создание массива А
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = i;
                }

                //Заполнение последовательно
                double[] b = new double[n];
                DateTime d1 = DateTime.Now;
                for (int i = 0; i < n; i++)
                {
                    double s = 0;
                    for (int j = 0; j < i; j++)
                    {
                        s += Math.Pow(a[i], 1.789);
                    }
                    b[i] = s;
                }
                DateTime d2 = DateTime.Now;
                var d = (d2 - d1).TotalMilliseconds;
                //Console.WriteLine($"Time: {d} msc");

                //Заполнение параллельно
                double[] bp = new double[n];
                Thread[] threads = new Thread[m];
                DateTime dp1 = DateTime.Now;
                for (int i = 0; i < m; i++)
                {
                    int start = i + 1;
                    threads[i] = new Thread(() =>
                    {
                        int actions = 0;
                        for (int j = 0; j < n; j += m)
                        {
                            double s = 0;
                            for (int k = start; k < j; k++)
                            {
                                s += Math.Pow(a[k], 1.789);
                                actions++;
                            }
                            bp[j] = s;
                        }
                        Console.WriteLine($"Potok: {i}, actions = {actions}");
                    });
                    threads[i].Start();
                }
                for (int i = 0; i < m; i++)
                {
                    threads[i].Join();
                }
                DateTime dp2 = DateTime.Now;
                var dp = (dp2 - dp1).TotalMilliseconds;
                Console.WriteLine($"Time: {dp} msc");
            }
        }
    }
}


class Task5
{
    static void Print()
    {
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    }
    public static void Run()
    {
        int[] NS = { 1000, 5000, 10000, 15000, 20000 };
        int[] MS = { 1,2,4,8,12,16,20 };

        foreach (int n in NS)
        {
            foreach (int m in MS)
            {
                Console.WriteLine($"N = {n}, M = {m}");
                //Создание массива А
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    a[i] = i;
                }

                //Заполнение последовательно
                double[] b = new double[n];
                DateTime d1 = DateTime.Now;
                for (int i = 0; i < n; i++)
                {
                    double s = 0;
                    for (int j = 0; j < i; j++)
                    {
                        s += Math.Pow(a[i], 1.789);
                    }
                    b[i] = s;
                }
                DateTime d2 = DateTime.Now;
                var d = (d2 - d1).TotalMilliseconds;
                //Console.WriteLine($"Time: {d} msc");

                //Заполнение параллельно
                double[] bp = new double[n];
                Thread[] threads = new Thread[m];
                DateTime dp1 = DateTime.Now;
                for (int i = 0; i < m; i++)
                {
                    int start = i + 1;
                    threads[i] = new Thread(() =>
                    {
                        int actions = 0;
                        for (int j = 0; j < n; j+=m)
                        {
                            double s = 0;
                            for (int k = start; k < j; k++)
                            {
                                s += Math.Pow(a[k], 1.789);
                                actions++;
                            }
                            bp[j] = s;
                        }
                        Console.WriteLine($"Potok: {i}, actions = {actions}");
                    });
                    threads[i].Start();
                }
                for (int i = 0; i < m; i++)
                {
                    threads[i].Join();
                }
                DateTime dp2 = DateTime.Now;
                var dp = (dp2 - dp1).TotalMilliseconds;
                Console.WriteLine($"Time: {dp} msc");
            }
        }
    }
}


class Program
{
    static void Main()
    {
        bool GO = true;
        while (GO) {
            Console.WriteLine("1 - Task1");
            Console.WriteLine("2 - Task2");
            Console.WriteLine("3 - Task3");
            Console.WriteLine("4 - Task4");
            Console.WriteLine("5 - Task5");
            Console.WriteLine("Any other key - Exit");

            Console.Write("Choose which task to run: ");

            string n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    Task1.Run();
                    break;
                case "2":
                    Task2.Run();
                    break;
                case "3":
                    Task3.Run();
                    break;
                case "4":
                    Task4.Run();
                    break;
                case "5":
                    Task5.Run();
                    break;
                default:
                    GO = false;
                    break;
            }
        }  
    }
}