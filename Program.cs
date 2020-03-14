using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {
               string step;
               float a, b;
                Console.WriteLine("请输入两个整数");
                try
                {
                    a = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("请输入要执行的操作+ - * /");
                    step = Console.ReadLine();
                    switch (step)
                    {
                        case "+":
                            {
                                Console.WriteLine("{0}+{1}={2}",a,b,a+b);
                                break;
                            }
                        case "-":
                            {
                                Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                                break;
                            }
                        case "*":
                            {
                                Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                                break;
                            }
                        case "/":
                            {
                                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                                break;
                            }
                    }
                }
                catch
                {
                    Console.WriteLine("发生异常，请重启程序");
                }
        }
    }
}
