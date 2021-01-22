using System;

namespace Ha21092021
{
    class Program
    {
        static void Main(string[] args)
        {
            //задание 2
             int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a!= b)
            {
                if (a > b)
                {
                    System.Console.WriteLine(a);
                    System.Console.WriteLine(b = a);
                }
                else
                {
                    System.Console.WriteLine(a = b);
                    System.Console.WriteLine(b);
                }
            }
            else if (a == b)
            {
                System.Console.WriteLine(a = 0);
                System.Console.WriteLine(b = 0);
       

        //задание3

        System.Console.WriteLine("Пожалуйста, войдите в режим работы");
            var firstOperand = Convert.ToDouble(Console.ReadLine());
            var secondOperand = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, войдите в режим работы");
             char sign = Convert.ToChar(Console.ReadLine());
             switch (sign)
             {
                 case '+':
                     System.Console.WriteLine(firstOperand +  firstOperand);
                     break;
                case '-':
                    System.Console.WriteLine(firstOperand -  firstOperand);
                    break;
                case '*':
                     System.Console.WriteLine( firstOperand *  firstOperand);
                     break;
                 case '/':
                    if (secondOperand != 0)
                        System.Console.WriteLine( firstOperand / secondOperand);
                     else
                         System.Console.WriteLine("Не допускается деление на 0");
                    break;
             }

            //задание 4
             System.Console.WriteLine("Пожалуйста, введите номер");
             var num = Convert.ToDouble(Console.ReadLine());
             if (num >= 0 && num <= 15)
             {
                 System.Console.WriteLine("Вы находитесь в первом интервале");
             }
             else if (num > 15 && num <= 35)
             {
                 System.Console.WriteLine("Вы во втором интервале");
             }
             else if (num > 36 && num <= 50)
             {
                 System.Console.WriteLine("Вы находитесь в третьем интервале");
             }
             else if (num > 51 && num <= 100)
             {
                 System.Console.WriteLine("Вы находитесь на пятом интервале");
            }
             else
            {
                 System.Console.WriteLine("Вы ввели неправильный номер");
             }
             
            //задание 5

             System.Console.WriteLine("Пожалуйста, введите сумму покупки");
             var discount = 0.0;
             var purchase = Double.Parse(Console.ReadLine());
             if (purchase >= 500 && purchase < 1000)
             {
                 discount = purchase * 0.03;
                 System.Console.WriteLine($"Ваша скидка составляет 3%, а ваша сумма причитается {purchase - discount}");

             }
             else if (purchase >=1000)
             {
                 discount = purchase * 0.05;
                System.Console.WriteLine($"Ваша скидка составляет 5%, а ваша сумма причитается {purchase - discount}");
             }
             else if (purchase < 500)
             {
                 System.Console.WriteLine("Вы не имеете права на скидку");
             }

            //задание 6

             System.Console.WriteLine("Пожалуйста, укажите номера");
             var N = Int32.Parse(Console.ReadLine());
             var M = Int32.Parse(Console.ReadLine());
             var S = Int32.Parse(Console.ReadLine());
             var E = Int32.Parse(Console.ReadLine());

             var minab = 0;
             var mincd = 0;
             var min = 0;
            if (N < M && M < S && S < E)
            {
                System.Console.WriteLine("При условии, что числа находятся в порядке возрастания");
            }
            else
            {
                minab = Math.Min(N,M);
                mincd = Math.Min(S, E);
                min = Math.Min(minab, mincd);
                System.Console.WriteLine($"Минимальное количество {min}");
            }
            if (N == M && M == S && S == E)
            {
                System.Console.WriteLine(N * M * S * E);
            }

            //задание 7

            System.Console.WriteLine("Пожалуйста, укажите номера");
            var A = Int32.Parse(Console.ReadLine());
            var B = Int32.Parse(Console.ReadLine());
            var C = Int32.Parse(Console.ReadLine());

            int Max = 0, Mid = 0, Min = 0;
            if (A > B && B > C)
            {
                Max = A;
                Mid = B;
                Min = C;
                System.Console.WriteLine($"Максимальное количество {A = Max}");
                System.Console.WriteLine($"Среднее число-это {B = Mid}");
                System.Console.WriteLine($"Минимальное количество {C = Min}");
            }
            else if (B > A && A > C)
            {
                Max = B;
                Mid = A;
                Min = C;
                System.Console.WriteLine($"Максимальное количество {A = Max}");
                System.Console.WriteLine($"Среднее число-это {B = Mid}");
                System.Console.WriteLine($"Минимальное количество {C = Min}");
            }
            else if (C > B && B > A)
            {
                Max = C;
                Mid = B;
                Min = A;
                System.Console.WriteLine($"Максимальное количество {A = Max}");
                System.Console.WriteLine($"Среднее число-это {B = Mid}");
                System.Console.WriteLine($"Минимальное количество {C = Min}");
            }
            else if (A > B && A > C && B < C)
            {
                Max = A;
                Mid = C;
                Min = B;
                System.Console.WriteLine($"Максимальное количество {A = Max}");
                System.Console.WriteLine($"Среднее число-это {B = Mid}");
                System.Console.WriteLine($"Минимальное количество {C = Min}");
            }
            else if (A < B && B > C)
            {
                Max = B;
                Mid = C;
                Min = A;
                System.Console.WriteLine($"Максимальное количество {A = Max}");
                System.Console.WriteLine($"Среднее число-это {B = Mid}");
                System.Console.WriteLine($"Минимальное количество {C = Min}");
            }
        }

    }

        

   
    

