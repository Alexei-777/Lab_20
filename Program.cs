using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
//-метод получает входным параметром переменную типа double;
//-метод возвращает значение типа double, которое является результатом вычисления.

//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
//-длину окружности по формуле D = 2 * π* R;
//-площадь круга по формуле S = π* R²;
//-объем шара.Формула V = 4 / 3 * π * R³.

//Методы должны быть объявлены как статические.


namespace Lab_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус R=");
            double R = Convert.ToDouble(Console.ReadLine());
            MyDeligate myDeligate = new MyDeligate(Dlina);
            Console.WriteLine($"Длинна окружности с радиусом R= {R} равна: {myDeligate?.Invoke(R)}");
            myDeligate += Ploshad;
            Console.WriteLine($"Площадь круга с радиусом R= {R} равна: {myDeligate?.Invoke(R)}");
            myDeligate += Obem;
            Console.WriteLine($"Обьем шара с радиусом R= {R} равен: {myDeligate?.Invoke(R)}");
            Console.ReadKey();
        }
        delegate double MyDeligate(double R);
        static double Dlina(double R)
        {
            return 2 * Math.PI * R;
        }
        static double Ploshad(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        static double Obem (double R)
        {
            return 4 / 3 * Math.PI * Math.Pow(R, 3);
        }
        //static double Dlina(double R)   //для себя эксперементировал.
        //{
        //    return Convert.ToDouble(2 * Math.PI * R);
        //}
        //static double Ploshad(double R)
        //{
        //    return Convert.ToDouble(Math.PI * Math.Pow(R, 2));
        //}
        //static double Obem(double R)
        //{
        //    return Convert.ToDouble(4 / 3 * Math.PI * Math.Pow(R, 3));
        //}
    }
}
