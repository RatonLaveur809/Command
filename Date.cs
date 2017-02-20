using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace CommandPattern
{
    public class Date
    {
        DateTime date;

        public Date()
        {
            bool checkDate = false;

            while (checkDate == false)
            {
                Console.WriteLine("Введите дату");
                try
                {
                    date = DateTime.Parse(Console.ReadLine());
                    checkDate = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введённая дата некорректна");                    
                }
            }            
        }

        public void getFormattedDate()
        {
            Console.WriteLine("Дата в разных форматах:");
            Console.WriteLine(nameMonthPropis());
            Console.WriteLine(date.ToString(@"d\/MM\/yyyy"));
            Console.WriteLine(date.ToString("dd.MM.yy"));
        }

        public void getDay()
        {
            Console.WriteLine(date.ToString("dddd", new CultureInfo("ru-RU")));
        }

        String nameMonthPropis()
        {
            String[] d = new string[]
             { "января", 
               "февраля",
               "марта",
               "апреля",
               "мая",
               "июня",
               "июля",
               "августа",
               "сентября",
               "октября",
               "ноября",
               "декабря"
            };
            return Convert.ToString(date.Day) + " " + d[Convert.ToUInt32(date.Month - 1)] + " " + Convert.ToString(date.Year) + " года";
        }

        public void getDistance()
        {
            bool checkDate = false;
            DateTime d=new DateTime();
            TimeSpan time;

            while (checkDate == false)
            {
                Console.WriteLine("Введите дату для вычисления расстояния");
                try
                {
                    d = DateTime.Parse(Console.ReadLine());
                    checkDate = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Введённая дата некорректна");
                }
            }
            if (d > date)
                time = d - date;
            else
                time = date - d;
            Console.WriteLine("Расстояние между датами: "+time.Days+" дней");
        }
    }
}
