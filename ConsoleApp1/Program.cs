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
            private int currentDigit;
            private int numberStrLength;
            private int numberStrLengthElevated;

            public void setCurrentDigit(int number, int numberElevated) { this.currentDigit = number / numberElevated; }
            public void SetNumberStrLength(int number) { this.numberStrLength = number.ToString().Length; }

            public void SetNumberStrLengthElevated(int numberLength) { this.numberStrLengthElevated = (int)Math.Pow(10, numberLength - 1); }

            public int GetNumberStrLength() { return this.numberStrLength; }
            public int GetCurrentDigit() { return this.currentDigit; }
            public int GetNumberStrLengthElevated() { return this.numberStrLengthElevated; }

            
        }


        public static void Main(string[] args)
        {
            Number numberList = new Number();
            NumberConverter numberConverter = new NumberConverter();
            User user = new User();

            Console.WriteLine("Enter a number (Max: 9999)");

            user.SetNumber(Int32.Parse(Console.ReadLine()));
            int userNumber = user.GetNumber();

            if (userNumber == 0)
            {
                Console.WriteLine(numberList.GetCentenasYMiles()[0]);
                Console.ReadLine();
                return;
            }

            if (userNumber < 0 || userNumber > 9999)
            {
                Console.WriteLine("Number should be less than 9999 and greater than 0");
                Console.ReadLine();
                return;
            }

            Boolean flag = false;
            while (userNumber >= 0)
            {
                userNumberAsStringLength = userNumber.ToString().Length;
                if (userNumber > 0)
                {

                    value = (int)Math.Pow(10, userNumberAsStringLength - 1);
                    temp = userNumber / value;

                }

                switch (userNumberAsStringLength)
                {
                    case 1:
                        Console.Write(" " + unidades[temp - 1] + " ");

                        break;
                    case 2:
                        if (userNumber >= 10 && userNumber < 20)
                        {
                            userNumber = userNumber % value;

                            Console.Write(" " + decenasA[userNumber] + " ");

                            flag = true;

                        }
                        else
                        {
                            Console.Write(" " + decenasB[temp - 1] + " ");
                        }

                        break;
                    case 3:
                        Console.Write(unidades[temp - 1] + " " + centenasYMiles[1]);
                        break;
                    case 4:
                        Console.Write(" " + unidades[temp - 1] + " " + centenasYMiles[2] + " ");
                        break;
                }


                if (userNumber == value)
                {
                    Console.Write(" ");
                    break;
                }
                else
                {
                    userNumber = userNumber % value;
                }

                if (userNumber == 0 || flag == true)
                {
                    break;
                }

            }

        }
    }
}
