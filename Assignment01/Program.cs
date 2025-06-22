namespace Assignment01
{
    using System;
    using System.Drawing;

    public class Program
    {
        public static void Main()
        {
            #region Question1
            Console.WriteLine("PLease enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number is: " + number);
            #endregion

            #region Question2
            //Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string str = "123abc"; 
            //    int result = Convert.ToInt32(str);
            //    Console.WriteLine("Converted number: " + result);
            //System.FormatException: 'The input string '123abc' was not in a correct format.'
            #endregion

            #region Question3
            //Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            double dou = 5.55;
            double result = dou * 2;
            Console.WriteLine("The result is: " + result);
            //the dou variable will be taken by the result and will be multiplied by 2 and the result will be 11.1
            #endregion

            #region Question4
            //Write C# program that Extract a substring from a given string.
            string str = "Zeyad";
            string substring = str.Substring(4);
            Console.WriteLine("The substring is: " + substring);
            #endregion

            #region Question5
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int num1 = 5;
            int num2 = num1; // this variable will take the value of num1
            num1 = 10; // this wont affect num2 because the num2 has already the value of num1 which is 5
            Console.WriteLine("number 1 is: " + num1 + "\nnumber 2: " + num2);
            #endregion

            #region Question6
            //Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            Point point1 = new Point();
            Point point2 = point1;// point2 will reference the same object as point1
            point1.X = 5;//assigning the value of X to point1
            point1.Y = 5;//assigning the value of Y to point1
            Console.WriteLine("point1 X: " + point1.X + "\npoint1 Y: " + point1.Y);
            Console.WriteLine("point2 X: " + point2.X + "\npoint2 Y: " + point2.Y);
            #endregion

            #region Question7
            //Write C# program that take two string variables and print them as one variable 
            string str1 = "Zeyad ";
            string str2 = "Mohamed";
            string fullName = str1 + str2;
            Console.WriteLine("Full Name: " + fullName);
            #endregion

            #region Question8

            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d); //1 b)	A value 1 will be assigned to d.
            #endregion

            #region Question9
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // d)	6 1
            #endregion

            #region Question10

            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);
            //d)	7 7
            #endregion
        }
    }
}