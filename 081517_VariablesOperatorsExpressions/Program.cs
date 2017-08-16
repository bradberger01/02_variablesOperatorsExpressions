using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081517_VariablesOperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Brad";
            //Console.WriteLine(name);

            //name = "Dave";
            //Console.WriteLine(name);
            ////Case matters when naming variables
            //string Name = "Brad";

            //string birthMonth = "February";

            //Console.WriteLine(birthMonth);
            //integers
            int birthMonthNumber = 12;
            int age = 65;
            int population = 100000;
            //Floating type variables

            float number = 2.164403304897294383961032f;
            double someNumber = 2.164403304897294383961032d;
            decimal partialNumber = 2.164403304897294383961032m;
            //decimal ends with m for some reason
            //Console.WriteLine(number);
            //Console.WriteLine(someNumber);
            //Console.WriteLine(partialNumber);

            //boolean
            //bool isPresent = true;
            //bool seatTaken = false;

            ////Character
            //char lastLetter = 'j';

            //int jessicaAge = 23;
            //int samAge = 47;
            //Console.WriteLine(jessicaAge > samAge);

            int mikeBill = 13;
            int jimBill = 13;
            int frankBill = 13;
            int benBill = 13;
            Console.WriteLine(mikeBill + jimBill + frankBill + benBill);

            int totalCups = 7;
            int usedCups = 2;
            Console.WriteLine(totalCups - usedCups);

            int oneDiaper = 8;
            int moneyTotal = 40;
            Console.WriteLine(moneyTotal / oneDiaper);

            int treTotal = 41;
            int treFri = 29;
            Console.WriteLine(treTotal - treFri);

            int pranRun = 47;
            Console.WriteLine(pranRun + 30);

            int boxMoney = 12;
            int perBox = 3;
            Console.WriteLine(boxMoney / perBox);

            float newTotal = 27.10f;
            float saladCost = 5.12f;
            Console.WriteLine(newTotal + saladCost);

            int totalStudents = 331;
            int carStudents = 7;
            int busStudents = (totalStudents - carStudents);
            Console.WriteLine(busStudents / 6);





        }
    }
}
