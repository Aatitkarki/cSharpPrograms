using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial5
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateArea();
            //SumToN();
            //DisplayAddress();

            //SumNAverage();
            //OddEven();
            //calculatingFact();
            //   MarksGrader();
            //FindGreatestNum();
            //FindSmallestNum();
            MultiplicationOfFive();
            CalculateTax();
            Console.ReadLine();
        }
        public static void CalculateArea()
        {
            Console.WriteLine("Enter the radius of circle: ");
            int radius =  int.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine("The area of circle is: {0}",area);
        }

        public static void SumToN()
        {
            Console.WriteLine("Enter the number to find the sum to N: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
                for(int i = 1; i <= num; i++) {
                sum += i;
            }
            Console.WriteLine("The sum to {0} is: {1}",num,sum);
        }

        public static void SumNAverage()
        {
            Console.WriteLine("Enter the total no of Numbers you want to insert: ");
            int noOfNum = int.Parse(Console.ReadLine());
            int[] numbers = new int[noOfNum]; 
            for(int i = 0; i < noOfNum; i++)
            {
                Console.WriteLine("Enter the number for index {0}: ",i);
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            int sum = 0;
            for (int i = 0; i < noOfNum; i++)
            {
              sum+=  numbers[i];
            }
            double average = sum / noOfNum; 
            Console.WriteLine("The sum of entered numbers is as: {0}", sum);
            Console.WriteLine("The average is as: {0}", average);

        }

        public static void OddEven()
        {

            Console.WriteLine("Enter the number to check odd or even: ");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("THe number {0} is even", num);

            }
            else
            {

                Console.WriteLine("THe number {0} is odd", num);
            }
        }

        public static void calculatingFact()
        {
        Console.WriteLine("Enter the number to find factorial: ");
        int num = int.Parse(Console.ReadLine());
            int fact = CalcFactorial(num);
            Console.WriteLine("The factorial is as: {0}",fact);
        }
        
        public static int CalcFactorial(int num)
        {
            if(num ==0)
            {
                return 1;

            }
            else
            {
                return num * CalcFactorial(num - 1);

            }
        }
        static void MarksGrader()
        {
            Console.WriteLine("Please input your marks: ");
            int marks = int.Parse(Console.ReadLine());
            String grade = "";
            if (marks >= 90 && marks <= 100)
            {
                grade = "A+";
            }
            else if (marks >= 80 && marks < 90)
            {
                grade = "A";
            }
            else if (marks >= 70 && marks < 80)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }
            Console.WriteLine("You have obtained grade: "+ grade);
            Console.ReadLine();
        }

        //Accept user’s name, city,
        //street, pin and house no. and store it in a variable and display it.
        public static void DisplayAddress()
        {
            Console.WriteLine("Enter your name: ");
            String userName = Console.ReadLine();
            Console.WriteLine("Enter your city name: ");
            String userCity = Console.ReadLine();
            Console.WriteLine("Enter your street: ");
            String street = Console.ReadLine();
            Console.WriteLine("Enter your pin no: ");
            String pin = Console.ReadLine();
            Console.WriteLine("Enter your house no: ");
            String houseNo = Console.ReadLine();
            Console.WriteLine("{0} your mailing address is as: \nCity Name: {1}\nStreet: {2}\nPin No: {3}\nHouse no: {4}",userName,userCity,street,pin,houseNo);
        }
        public static void FindGreatestNum()
        {
            Console.WriteLine("Enter the first Number: ");
            int fNum =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            int sNum =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the third Number: ");
            int tNum =int.Parse( Console.ReadLine());

            if (fNum > sNum && sNum> tNum) {
            Console.WriteLine("The greatest Number is:{0}",fNum);
            }else if(sNum > tNum && tNum> fNum)
            {
            Console.WriteLine("The greatest Number is:{0}",sNum);
            }
            else
            {
            Console.WriteLine("The greatest Number is:{0}",tNum);
            }
        }
        public static void FindSmallestNum()
        {
            Console.WriteLine("Enter the first Number: ");
            int fNum =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the second Number: ");
            int sNum =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter the third Number: ");
            int tNum =int.Parse( Console.ReadLine());

            if (fNum < sNum && sNum< tNum) {
            Console.WriteLine("The smallest Number is:{0}",fNum);
            }else if(sNum < tNum && tNum< fNum)
            {
            Console.WriteLine("The smallest Number is:{0}",sNum);
            }
            else
            {
            Console.WriteLine("The smallest Number is:{0}",tNum);
            }
        }
        public static void MultiplicationOfFive()
        {
            int num = 5;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1}  = {2}", num, i, num * i);
            }

        }
        public static void CalculateTax()
        {

            Console.WriteLine("Enter the total amount of salary Received: ");
            int salary = int.Parse(Console.ReadLine());
            double totalTax = 0;
            if(salary <= 10000)
            {
                totalTax =salary -( salary * 0.5);
            }else if(salary <= 100000)
            {
                totalTax =(10000 -  (10000 * 0.5))+  ((salary-10000) - ( (salary-10000) * 0.8));
            }
            else
            {
                totalTax =(10000 -  (10000 * 0.5))+  (100000 - (100000 * 0.8))+ ((salary-110000) - ( (salary-110000) * 0.85));
            }
                Console.WriteLine("The total Tax to be paid at salary {0} is {1}",salary ,totalTax);
        }
    }
}
