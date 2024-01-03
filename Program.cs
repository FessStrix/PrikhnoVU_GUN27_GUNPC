using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
        
           if 
            (int.TryParse(Console.ReadLine(), out var x)) 
            {
                //обработка
            }
                else
                {
                Console.Write("Ошибка.Некорректное число");
                Console.ReadKey();
                return;
                }    
            Console.Write("Введите второе число: ");
            if
         (int.TryParse(Console.ReadLine(), out var y))
            {
                //обработка
            }
            else
            {
                Console.Write("Ошибка.Некорректное число");
               Console.ReadKey();
                return;
            }
            
            Console.Write("Введите оператор(&,| или ^): ");
             char z= Convert.ToChar(Console.ReadLine());
          

            switch (z) 
            {
                case '&':

                    Console.WriteLine("В двоичной системе {0} & {1}= {2}", x,y, Convert.ToString(x & y,2));
                    Console.WriteLine("В десятичной системе {0} & {1}= {2}", x, y,(x & y));
                    Console.WriteLine("В шестнадцатиричной системе {0} & {1}= {2}", x, y, Convert.ToString(x & y, 16));                
                    Console.ReadKey();
                    break;
                case '|':
                    Console.WriteLine("В двоичной системе {0} | {1}= {2}", x, y, Convert.ToString(x | y, 2));
                    Console.WriteLine("В десятичной системе {0} | {1}= {2}", x, y, (x | y));
                    Console.WriteLine("В шестнадцатиричной системе {0} | {1}= {2}", x, y, Convert.ToString(x | y, 16));
                    Console.ReadKey();
                    break;
                case '^':
                    Console.WriteLine("В двоичной системе {0} ^ {1}= {2}", x, y, Convert.ToString(x ^ y, 2));
                    Console.WriteLine("В десятичной системе {0} ^ {1}= {2}", x, y, (x ^ y));
                    Console.WriteLine("В шестнадцатиричной системе {0} ^ {1}= {2}", x, y, Convert.ToString(x ^ y, 16));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Неверный оператор"); //проверка ввода оператора
                    Console.ReadKey();
                    break;







            }


        }
    }
}
