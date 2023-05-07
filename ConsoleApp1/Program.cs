using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    internal class Customer
{
    // attributes
    private int IdNumber;
    private string Name;
    private double Total;
 
    // setters
    public void SetIdNumber(int IdNumber) { this.IdNumber = IdNumber; }
    public void SetName(string Name) { this.Name = Name; }
    public void SetTotal(double Total) { this.Total = Total; }
 
    // getters
    public int GetIdNumber() { return this.IdNumber; }
    public string GetName() { return this.Name; }
    public double GetTotal() { return this.Total; }
}
*/

namespace ConsoleApp1
{
    public class Program
    {

        public class Number
        {
            private string[] unidades = { "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };
            private string[] decenasA = { "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINTEEN" };
            private string[] decenasB = { "TEN", "TWENTY", "THIRTY", "FOURTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };
            private string[] centenasYMiles = { "ZERO", "HUNDRED", "THOUSAND" };

            public string[] GetUnidades()
            {
                return this.unidades;
            }

            public string[] GetDecenasA()
            {
                return this.decenasA;
            }

            public string[] GetDecenasB()
            {
                return this.decenasB;
            }

            public string[] GetCentenasYMiles()
            {
                return this.centenasYMiles;
            }

        }

        public class User
        {
            private int number;

            public void SetNumber(int number) { this.number = number; }

            public int GetNumber() { return this.number; }
        }

        public class NumberConverter
        {
            private int temp;
            private int userNumberAsStringLength;
            private int value;
        }


        public static void Main(string[] args)
        {

        }
    }
}
