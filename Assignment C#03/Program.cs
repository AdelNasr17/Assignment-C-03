using System.Collections.Generic;
using System.ComponentModel;

namespace Assignment_C_03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Q1: Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write(" Please Enter The Number : ");
            //int.TryParse(Console.ReadLine(), out int Number );

            //if(Number % 3 ==0 && Number%4==0)
            //{
            //    Console.WriteLine(" Yes, this number is divisible by 3 and 4.");
            //}
            //else
            //{
            //    Console.WriteLine("NO , this number is not divisible by 3 and 4.");
            //}

            #endregion

            #region Q2 : Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write( " Please Enter an Integer Number : ");

            //int.TryParse( Console.ReadLine(), out int Number );

            //if ( Number < 0 )
            //{
            //    Console.WriteLine("This number is negative ");
            //}

            //else
            //{
            //    Console.WriteLine("This number is positive.");
            //}

            #endregion

            #region Q3 : Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("please Enter 3 Numbers : ");
            //Console.Write(" The First Number :  ");
            //int.TryParse(Console.ReadLine(), out int Num1);
            //Console.Write(" The Second Number :  ");
            //int.TryParse(Console.ReadLine(), out int Num2);
            //Console.Write(" The third Number :  ");
            //int.TryParse(Console.ReadLine(), out int Num3);

            //int Max = Math.Max(Num1, Math.Max(Num2, Num3));
            //int Min = Math.Min(Num1, Math.Min(Num2, Num3));

            //Console.Clear();
            //Console.WriteLine($"Max Element : {Max} ");
            //Console.WriteLine($"Min Element : {Min} ");


            #endregion

            #region Q4 : Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Please Enter The Number  : " );
            //int.TryParse(Console.ReadLine(), out  int Number);

            //if (Number % 2 == 0)
            //{
            //    Console.WriteLine("This Number Is Even");
            //}
            //else
            //{
            //    Console.WriteLine("This Number Is odd ");
            //}

            #endregion

            #region Q5 : Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write(" Please Enter The character : ");
            //char.TryParse(Console.ReadLine(),out char Character);
            //char UpperChar=char.ToLower(Character);

            //switch (UpperChar)
            //{ 
            //    case 'a':
            //    case 'e':
            //    case 'I':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine(" This Letter is Vowel ");
            //        break;

            //    default:
            //        Console.WriteLine("This Letter is consonant");
            //        break;     
            //}
            #endregion

            #region Q6 : Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write(" Please Enter A Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //for (int i = 0; i <= Number; i++)
            //{
            //    Console.Write($"{i} ");
            //}


            #endregion

            #region Q7 : Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write(" Please Enter A Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //for (int i = 0; i <= 12; i++)
            //{
            //    int multiplication = i * Number;
            //    Console.Write($" {multiplication}  ");
            //}

            #endregion

            #region Q8 : Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write(" Please Enter A Number : ");
            //int.TryParse(Console.ReadLine(), out int Number);

            //for (int i = 1; i <= Number; i++)
            //{
            //    if(i%2==0)
            //    {
            //        Console.Write( $"{i}  ");
            //    }

            //}

            #endregion

            #region Q9 : Write a program that takes two integers then prints the power.
            //Console.Write(" Please enter Base Number : ");
            //int.TryParse(Console.ReadLine(), out int BaseNum);
            //Console.Write(" Please enter Ex Num^ : ");
            //int.TryParse(Console.ReadLine(), out int NumOs);

            //double Power = Math.Pow(BaseNum,NumOs);
            //Console.Clear();
            //Console.WriteLine($"{ BaseNum} ^ {NumOs} = {Power}");

            #endregion

            #region Q10 : Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine(" Please enter  marks of five subjects ");
            //int[] marks = new int[5];
            //Console.Write("Subject 1 : ");
            //int.TryParse(Console.ReadLine(), out marks[0]);
            //Console.Write("Subject 2 : ");
            //int.TryParse(Console.ReadLine(), out marks[1]);
            //Console.Write("Subject 3 : ");
            //int.TryParse(Console.ReadLine(), out marks[2]);
            //Console.Write("Subject 4 : ");
            //int.TryParse(Console.ReadLine(), out marks[3]);
            //Console.Write("Subject 5 : ");
            //int.TryParse(Console.ReadLine(), out marks[4]);

            //double Total = 0;

            //for (int i = 0; i < 5 ; i++)
            //{
            //    Total += marks[i];

            //}

            //Console.Clear();
            //double Average =  Total / 5;
            //double percentage = (Total / 500 ) * 100;

            //Console.WriteLine($"  Total Marks = {Total}");
            //Console.WriteLine($"  Average Marks = {Average}");
            //Console.WriteLine($"  percentage  = {percentage}%");

            #endregion

            #region Q11 : Write a program to input the month number and print the number of days in that month.

            //Console.Write(" Please Enter The Month Number : ");
            //int.TryParse(Console.ReadLine(), out int Month );

            //switch(Month )
            //{
            //    case 1:  case 3: case 5: case 7: case 8: case 10: 
            //    case 12:
            //        Console.WriteLine( " Days in Month : 31 ");
            //        break;

            //    case 2: 
            //         Console.WriteLine(" Days in Month : 28 ");
            //        break;

            //    case 4: case 6: case 9: 
            //    case 11:
            //        Console.WriteLine(" Days in Month : 30 ");
            //        break;

            //}

            #endregion

            #region Q12 :  Write a program to create a Simple Calculator.
            

            //Console.Write(" Please Enter Number : ");
            //double.TryParse(Console.ReadLine(), out double Num1);

            //string Option;

            //do
            //{
            //    Console.Write(" Please Enter  Process Type : ");
            //    char.TryParse(Console.ReadLine(), out char ProcType);

            //    Console.Write(" Please Enter Number : ");
            //    double.TryParse(Console.ReadLine(), out double Num2);
            //    double Result = 0;

            //    if (ProcType == '+')
            //    {
            //        Result = Num1 + Num2;
            //    }
            //    else if (ProcType == '-')
            //    {
            //        Result = Num1 - Num2;
            //    }
            //    else if (ProcType == '*')
            //    {
            //        Result = Num1 * Num2;
            //    }
            //    else if (ProcType == '/')
            //    {
            //        if (Num2 == 0)
            //        { Console.WriteLine(" Error"); }
            //        else
            //        {
            //            Result = Num1 / Num2;
            //        }
            //    }
            //    else if (ProcType == '%')
            //    {
            //        Result = Num1 % Num2;
            //    }
            //    else
            //    {
            //        Result = 0;

            //    }
            //    Console.Clear();
            //    Console.WriteLine($" Result : {Result} ");

            //    Result = Num1;

            //    Console.Write("if you want to complete the process  ( Yes or No ) : ");
            //    Option = Console.ReadLine()?.ToLower();

            //} while (Option == "yes");

            //Console.WriteLine("Exiting The Process");
            //return;

            #endregion



        }
    }
}
