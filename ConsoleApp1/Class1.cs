using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Date
    {
        protected DateTime date { set; get; }
    }
    class MyDate : Date
    {
        public MyDate(int d, int m, int y)
        {
            date = new DateTime(y, m, d);
        }
        public bool IfLeap(DateTime date)
        {
            if (date.Year % 4 == 0 && (date.Year % 400 == 0 || date.Year % 100 != 0))
            {
                Console.WriteLine("Год высокосный");
                return true;
            }
            else
            {
                Console.WriteLine("Год не высокосный");
                return false;
            }
        }
        public bool IfToDay(DateTime date)
        {
            DateTime today = DateTime.Today;
            if (date < today)
            {
                Console.WriteLine("Дата раньше текущей");
                return false;
            }
            else if (date == today)
            {
                Console.WriteLine("Введена текущая дата");
                return true;
            }
            else
            {
                Console.WriteLine("Дата позже текущей");
                return true;
            }
        }
        public void PlusDay()
        {
            date = new DateTime(date.Year, date.Month, date.Day + 1);
        }
        public void Time() => Console.WriteLine(DateTime.Now.ToLongTimeString());
        public void Date() => Console.WriteLine(DateTime.Now.ToLongDateString());
        public void Day() => Console.WriteLine(DateTime.Now.DayOfWeek);
    }
    class DateInterface : MyDate
    {
        public DateInterface(int d, int m, int y) : base(d, m, y)
        {

        }
        public void Show()
        {
            Action[] show = new Action[] { base.Time, base.Date, base.Day };
            foreach (var item in show)
            {
                item();
            }
        }
        public void CheckDate()
        {
            Predicate<DateTime>[] check = new Predicate<DateTime>[] { base.IfToDay, base.IfLeap };
            if (check[0](base.date))
                Console.WriteLine(" ");
            if (check[1](base.date))
                Console.WriteLine(" ");
        }

    }
}
