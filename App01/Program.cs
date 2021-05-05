using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.Title = "Анкета";
            Console.WriteLine("Укажите свои параметры");
            Console.Write("Имя: ");
            string name = Console.ReadLine();
            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();
            Console.Write("Возраст: ");
            string age = Console.ReadLine();
            Console.Write("Рост: ");
            string height = Console.ReadLine();
            Console.Write("Вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine(name + " " + surname +" " + "Возраст: " +  age +" " +"Рост: "  + " "  + height + " " + "Вес:  "  +  weight);
            Console.WriteLine("Ваши параметры(Имя, фамилия, возраст, рост и вес): " + "{0}  {1}  {2}  {3} {4}", name, surname, age, height, weight); 
            Console.WriteLine("Ваши параметры(Имя, фамилия, возраст, рост и вес): " + $" {name}  {surname}  {age}  {height}   {weight}");

            Console.ReadLine();
            #endregion

            #region Task2
            Console.Title = "Индекс массы тела";
            Console.Write("Введите ваш вес: ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ваш рост(в метрах): ");
            double h = Convert.ToDouble(Console.ReadLine());
            double i = m / (h * h);
            Console.WriteLine("Индекс массы тела равен: " + i);
            Console.ReadLine();

            #endregion

            #region Task 3
            Console.Title = "Рассчет расстояния между координатами";
            //Не понял что надо сделать
            Console.ReadLine();
            #endregion

            #region Task4
            Console.Title = "Обмен значениями";
            int a = 10;
            int b = 5;
            int c = a;
            a = b;
            b = c;
            Console.ReadLine();

            #endregion

            #region Task 5
            Console.Title = "Задание 5";
            Console.WriteLine("{0, 70}", "Кутырев Николай, Санкт-Петербург");
            Console.ReadLine();

            #endregion
        }
    }
}
