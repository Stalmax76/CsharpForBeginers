using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        

        NumberFormatInfo numberFormatInfo = new NumberFormatInfo
        {
            NumberDecimalSeparator = ".",
        };

        static double firstNumber;
        static double secondNumber;
        static double result;
        static char action;
        static bool num1 = true;
        static bool num2 = true;
        static bool dates = true;

          static void Main(string[] args)
        {
            #region array names
            // Создание массива строк
            /*int size;
            Console.WriteLine("Введите размер создаваемого массива");
            int.TryParse(Console.ReadLine(), out size);
            string[] names = new string[size];
            for(int i =0;i<names.Length;i++)
            {
                
                Console.WriteLine($"Введите имя для {i+1} элемента");
                names[i] = Console.ReadLine();
               
            }

            Console.WriteLine($"Вы создали массив строк \"names\" на {size} элементов: \n");
            foreach (var name in names)
            {
                Console.Write("\t" + name + "\n");
            }*/
            #endregion




            EnterDate();
            ActionSelection();

            if (action != '+' || action != '-' || action != '+' || action != '+' || action != '+')
            {
                switch (action)
                {
                    case '+':
                        Sum();
                        break;
                    case '-':
                        Subtraction();
                        break;
                    case '*':
                        Multiplication();
                        break;
                    case '/':

                        if (secondNumber != 0)
                        {
                            Devide();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Division by zero, action cannot be performed");
                            break;
                        }
                    case '%':
                        if (secondNumber != 0)
                        {
                            DevideModule();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Division by zero, action cannot be performed");
                            break;
                        }

                    default:

                        Console.WriteLine("Enter valid data and correct actions!");
                        break;
                }
            }
            else
            {
                return;
            }
            Console.ReadKey();


        }

        private static void DevideModule()
        {
            result = firstNumber % secondNumber;
            Console.WriteLine("{0}  {1}  {2} = {3}", firstNumber, action, secondNumber, result);
            dates = num2 = num1 = true;
        }

        private static double Devide()
        {
            result = firstNumber / secondNumber;
            Console.WriteLine("{0}  {1}  {2} = {3}", firstNumber, action, secondNumber, result);
            dates = num2 = num1 = true;
            return result;
        }

        private static double Multiplication()
        {
            result = firstNumber * secondNumber;
            Console.WriteLine("{0}  {1}  {2} = {3}", firstNumber, action, secondNumber, result);
            dates = num2 = num1 = true;
            return result;
           
        }

        private static double Subtraction()
        {
            result = firstNumber - secondNumber;
            Console.WriteLine("{0}  {1}  {2} = {3}", firstNumber, action, secondNumber, result);
            dates = num2 = num1 = true;
            return result;
        }

        private static double Sum()
        {
            result = firstNumber + secondNumber;
            Console.WriteLine("{0}  {1}  {2} = {3}", firstNumber, action, secondNumber, result);
            dates = num2 = num1 = true;
            return result;
        }

        private static char ActionSelection()
        {
            Console.WriteLine("select the action to be performed: '+', '-', '/', '*', '%'");   // '+', '-', '/', '*', '%'
            char.TryParse(Console.ReadLine(), out action);
            return action;
        }

        private static bool EnterDate()
        {
            if (dates)
            {
                if (num1)
                {
                    Console.WriteLine("Enter the first number");
                    double.TryParse(Console.ReadLine(), out firstNumber);

                    num1 = false;
                }

                 if(num2)
                {
                    Console.WriteLine("Enter the second number");
                    double.TryParse(Console.ReadLine(), out secondNumber);
                    num2 = false;
                }

                dates = false;
            }
            
            return dates;
        }
    }

}
    



