using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculatorClass = StringCalculator.App.StringCalculator;


namespace StringCalculator.App
{
    internal class Program
    {
        private static StringCalculatorClass _calculator;

        static void Main(string[] args)
        {
            _calculator = new StringCalculatorClass();

            //Console.WriteLine(_calculator.Add(""));
            //Console.WriteLine(_calculator.Add("1"));
            //Console.WriteLine(_calculator.Add("1,2"));
            //Console.WriteLine(_calculator.Add("1,2,3,4"));
            //Console.WriteLine(_calculator.Add("1\n2,3"));
            //Console.WriteLine(_calculator.Add("//;\n1;2"));
            //try
            //{
            //    _calculator.Add("1,-2,-3");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //Console.WriteLine(_calculator.Add("2,1001"));
            //Console.WriteLine(_calculator.Add("//[***]\n1***2***3"));
            //Console.WriteLine(_calculator.Add("//[*][%]\n1*2%3"));
            Console.WriteLine(_calculator.Add("//[***][%%]\n1***2%%3"));

            Console.ReadKey();
        }
    }
}
