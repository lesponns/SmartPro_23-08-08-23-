using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_23_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _input_1, _input_2, calc, last;

            Console.Write("İlk Sayı: ");
            _input_1 = int.Parse(Console.ReadLine());
            Console.Clear();
            
            Console.Write("İkinci Sayı: ");
            _input_2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.Write("İşlem seçiniz. \n1 Toplama \n2 Çıkarma \n3 Çarpma \n4 Bölme \nİşleminiz: ");
            calc = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (calc) 
            {
                case 1:
                    last = _input_1 + _input_2;
                    Console.WriteLine("İşlem sonucu "+_input_1+" + "+_input_2+" = "+last);
                    break;
                case 2:
                    last = _input_1 - _input_2;
                    Console.WriteLine("İşlem sonucu " + _input_1 + " - " + _input_2 + " = " + last);
                    break;
                case 3:
                    last = _input_1 * _input_2;
                    Console.WriteLine("İşlem sonucu " + _input_1 + " * " + _input_2 + " = " + last);
                    break;
                case 4:
                    last = _input_1 / _input_2;
                    Console.WriteLine("İşlem sonucu " + _input_1 + " / " + _input_2 + " = " + last);
                    break;
                default: Console.WriteLine("Wrong way!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
