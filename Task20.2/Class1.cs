using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    public class Class1
    {
        public static int ReadFromConsol()
        {
            Console.WriteLine("Введите число");
            string s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            return n;
        }

        //1) Метод получает на вход 3 числа (A, B и С). Верните решение (значение X) линейного уравнения стандартного вида, где A*X+B=C.
        public static string LinearEquation(int a, int b, int c)
        {
            double x = 0;
            double y = 0;
            int discriminant = (b * b) * (4 * a * c);

            if (discriminant <= 0)
            {
                Console.WriteLine("0");
            }
            else if (discriminant > 0)
            {
                x = (-b + Math.Sqrt(discriminant)) / 2;
                y = (-b - Math.Sqrt(discriminant)) / 2;
                Console.WriteLine($" X1 = {x}, X2 = {y}");
            }
            else if (discriminant == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine($"x = {x}");

            }
            return $"{x},{y}";
        }

        //2) Метод получает на вход 2 числа (A и B). Если A больше B, подсчитать A+B, если A равно B, подсчитать A*B, если A меньше B, подсчитать A-B.
        public static int ComparisonOfTwoNumber(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a + b;
                Console.WriteLine(result);
            }
            if (a == b)
            {
                result = a * b;
                Console.WriteLine(result);

            }
            if (a < b)
            {
                result = a - b;
                Console.WriteLine(result);
            }
            return result;
        }

        //3) Метод получает на вход двузначное число. Верните прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string UppercaseNumber(int number)

        {
            if (number < 10 || number >= 100)
            {
                throw new ArgumentException();
            }

            int dozense = number / 10;
            int unit = number % 10;
            string result = "";

            switch (dozense)
            {
                case 1:

                    switch (unit)
                    {
                        case 0:
                            result = "Десять";
                            break;
                        case 1:
                            result = "Одиннадцать";
                            break;
                        case 2:
                            result = "Двенадцать";
                            break;
                        case 3:
                            result = "Тринадцать";
                            break;
                        case 4:
                            result = "Чеиырнадцать";
                            break;
                        case 5:
                            result = "Пятнадцать";
                            break;
                        case 6:
                            result = "Шестнадцать";
                            break;
                        case 7:
                            result = "Семнадцать";
                            break;
                        case 8:
                            result = "Восемнадцать";
                            break;
                        case 9:
                            result = "Девятнадцать";
                            break;
                    }
                    break;

                case 2:
                    result = "Двадцать ";
                    break;
                case 3:
                    result = "Тридцать ";
                    break;
                case 4:
                    result = "Сорок ";
                    break;
                case 5:
                    result = "Пятьдесят ";
                    break;
                case 6:
                    result = "Шестьдесят ";
                    break;
                case 7:
                    result = "Семьдесят ";
                    break;
                case 8:
                    result = "Восемьдесят ";
                    break;
                case 9:
                    result = "Девяносто ";
                    break;
            }

            if (dozense != 1) 
            switch (unit)
            {
                case 1:
                    result += "Один";
                    break;
                case 2:
                    result += "Два";
                    break;
                case 3:
                    result += "Три";
                    break;
                case 4:
                    result += "Четыре";
                    break;
                case 5:
                    result += "Пять";
                    break;
                case 6:
                    result += "Шесть";
                    break;
                case 7:
                    result += "Семь";
                    break;
                case 8:
                    result += "Восемь";
                    break;
                case 9:
                    result += "Девять";
                    break;
            }
            Convert.ToString(number);
            return result;
        }

        //4) Метод получает на вход число. Проверить попадает ли оно в один из диапазонов: от 0 до 10, от 20 до 30 или от 40 до 50. *Здесь хорошим вариантом будет вернуть true или false.
        public static bool NumberFromRange(int number)
        {
            if (number >= 0 && number <= 10)
            {

                return true;
            }
            else if ((number >= 20 && number <= 30))
            {
                return true;
            }
            else if (number >= 40 && number <= 50)
            {
                return true;
            }

            return false;
        }

        //5) Метод получает на вход 2 числа (A и B). Верните сумму всех чисел из диапазона от A до B, которые делятся на 7.
        public static int SumOfRangeNumber(int number1, int number2)
        {
            int sum = 0;
            for (int i = number1; i <= number2; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
                else if (i < 0)
                {
                    sum = 0;
                    break;
                }
            }
            return sum;
        }

        //6) Метод получает на вход положительное число (N). Верните N-ое число ряда Фибоначчи
        public static int FibonacciNumber(int number) //fibo other value
        {
            if (number < 0)
            {
                throw new ArgumentException();
            }
            int fib1 = 1;
            int fib2 = 1;
            int n = number;
            int i = 0;
            while (i < n - 2)
            {
                int sum = fib1 + fib2;
                fib1 = fib2;
                fib2 = sum;
                i++;
            }
            return i;
        }

        //7) Метод получает на вход число. Найти количество нечетных цифр этого числа.
        public static int NumberOfOddDigits(int number)
        {
            int quantity = 0;
            while (number != 0)
            {
                int tmp = number % 10;
                if (tmp % 2 > 0)
                {
                    quantity++;
                }
                else if (tmp < 0)
                {
                    tmp = number * -1;
                    tmp = tmp % 10;
                    if (tmp % 2 > 0)
                    {
                        quantity++;
                    }
                }
                number /= 10;
            }
            return quantity;
        }

        //8) Метод получает на вход число. Найти число, которое является зеркальным
        public static int MirrorNumber(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException();
            }
            int result = 0;
            while (number > 0)
            {
                int tmp = number % 10;
                number = number / 10;
                result = result * 10;
                result = result + tmp;

            }
            return result;
        }

        //9) Метод получает на вход 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. Например, для пары 123 и 345, ответом будет являться true, а, для пары 500 и 999 - false.
        public static bool SameDigitsFromTwoNumbers(string number, string number2)
        {

            for (int i = 0; i < number.Length; i++)
            {
                for (int z = 0; z < number2.Length; z++)
                {
                    if (number[i] == number2[z])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}


