using System.Drawing;
using System.Security.Cryptography;
using System.Transactions;

namespace Assignment2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //Console.WriteLine("Enter the Number");
            //int num=int.Parse(Console.ReadLine());
            //for(int i = 1; i <= num;i++)
            //{

            //    Console.WriteLine(i);
            //}

            #endregion
            #region Q2 
            //Console.WriteLine("Enter Number");
            //int num=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(num*i);
            //}

            #endregion
            #region Q3
            //Console.WriteLine("Enter Number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i < num; i++) 
            //{
            //    if (i%2==0)
            //    Console.WriteLine(i);
            //}


            #endregion
            #region Q4
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the power");
            //int power = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result = result * num;
            //}
            //Console.WriteLine("Result = " + result); 
            #endregion
            #region Q5
            //Console.WriteLine("Enter the Five Marks");
            //int[]Marks=new int[5];
            //int total = 0;
            //for (int i = 0; i < 5; i++) 
            //{ 
            //    Marks[i]=int.Parse(Console.ReadLine());
            //    total=total+Marks[i];
            //}
            //double average = total / 5;
            //double percent = (average/100) * 100;
            //Console.WriteLine("Total = " + total);
            //Console.WriteLine("Average = " + average);
            //Console.WriteLine("Percentage= " + percent+"%");
            #endregion
            #region Q6
            //Console.WriteLine("Enter the string");
            //string Word=Console.ReadLine();
            //string reverse="";
            //for (int i = Word.Length-1; i >=0; i--)
            //{

            //    reverse += Word[i];

            //}
            //Console.WriteLine(reverse);
            #endregion
            #region Q7
            //Console.WriteLine("Enter integer number");
            //int Number = int.Parse(Console.ReadLine());
            //int ReverseNum = 0;
            //int reminder;
            //while (Number != 0)
            //{
            //    reminder = Number % 10;
            //    ReverseNum = ReverseNum * 10 + reminder;
            //    Number = Number / 10;
            //}
            //Console.WriteLine("Reverse Number = " + ReverseNum);
            #endregion
            #region Q8
            //Console.WriteLine("Input the start of range");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Input the End of range");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

            //for (int i = start; i <= end; i++)
            //{
            //    if (i > 1) 
            //    {
            //        int CountPrime = 0;

            //        for (int j = 2; j < i; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                CountPrime++;
            //                break;
            //            }
            //        }
            //        if(CountPrime == 0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}
            #endregion
            #region Q9
            //Console.WriteLine("Enter the decimal Number");
            //int Num = int.Parse(Console.ReadLine());
            //int reminder;
            //int BinaryNum = 0;
            //int pc = 1;
            //int Reverse = 0;
            //Console.WriteLine(Num);
            //while (Num != 0)
            //{

            //    reminder = Num % 2;
            //    BinaryNum = BinaryNum  + reminder*pc;
            //    Num = Num / 2;
            //    pc *= 10;

            //}

            //Console.WriteLine("BinaryNum: " + BinaryNum);

            #endregion
            #region Q10
            //        Console.WriteLine("Enter 3 Points");
            //        Point p1 = new Point() { x = int.Parse(Console.ReadLine()) 
            //            , y = int.Parse(Console.ReadLine()) };
            //        Point p2 = new Point()
            //        {
            //            x = int.Parse(Console.ReadLine())
            //,
            //            y = int.Parse(Console.ReadLine())
            //        };
            //        Point p3 = new Point()
            //        {
            //            x = int.Parse(Console.ReadLine())
            //,
            //            y = int.Parse(Console.ReadLine())
            //        };
            //        Console.WriteLine("p1=("+p1.x+","+p1.y+")");
            //        Console.WriteLine("p2=("+p2.x+","+p2.y+")");
            //        Console.WriteLine("p3=("+p3.x+","+p3.y+"");
            //        double Slope1 = ((p3.y - p2.y) / (p3.x - p2.x));
            //        double Slope2 = ((p2.y - p1.y) / (p2.x - p1.x));
            //        Console.WriteLine("Slope1 " + Slope1);
            //        Console.WriteLine("Slope2 " + Slope2);
            //        if (Slope1 == Slope2)
            //        {

            //            Console.WriteLine("The 3 Points lie on a straight line");
            //        }
            //        else
            //        {
            //            Console.WriteLine("The 3 Points don't lie on a straight line");

            //        }



            #endregion
            #region Q11
            //Console.WriteLine("Enter The Number of n for identity matrix");
            //int num =int.Parse(Console.ReadLine());
            //for (int i = 0; i < num; i++) 
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(" 1 ");

            //        }
            //        else { 
            //        Console.Write(" 0 ");
            //        }

            //    }
            //    Console.WriteLine();


            //}
            #endregion
            #region Q12
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            //int sum = 0;
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    sum+= Numbers[i];   
            //}
            //Console.WriteLine("Sum of elements of array= "+sum);
            #endregion
            #region Q13
            //Console.WriteLine("Enter size of array");
            //int size = int.Parse(Console.ReadLine());
            //int[]arr1 = new int[size];
            //int[]arr2 = new int[size];
            //int[]MergeArr = new int[size*2];
            //int i1=0,j1=0, k = 0;
            //Console.WriteLine("Enter the first Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter the second Arr");

            //for (int i = 0; i < size; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //while (i1 < size && j1 < size)
            //{
            //    if (arr1[i1] < arr2[j1])
            //    {
            //        MergeArr[k] = arr1[i1];
            //        i1++;


            //    }
            //    else
            //    {
            //        MergeArr[k] = arr2[j1];
            //        j1++;
            //    }
            //    k++;

            //}
            //while (i1 < size)
            //{
            //    MergeArr[k] = arr1[i1];
            //    i1++;
            //    k++;
            //}


            //while (j1 < size) 
            //{
            //    MergeArr[k] = arr2[j1];
            //    j1++;
            //    k++;
            //}

            //foreach (int i in MergeArr)
            //{
            //    Console.Write(i+" ");
            //}

            #endregion
            #region Q14
            //Console.WriteLine("Enter size");
            //int size=int.Parse(Console.ReadLine());
            //int []arr1=new int[size];
            //int counter = 1;
            //int []duplicate = new int[size];
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < size; i++) 
            //{
            //    if (duplicate[i] == 1) {
            //        continue;
            //    }
            //    for (int j = i+1; j < size; j++)
            //    {
            //        if (arr1[i] == arr1[j]) 
            //       {
            //            duplicate[j] = 1;
            //            counter++;
            //        }

            //    }
            //    Console.WriteLine("the element= "+arr1[i] +" appear " +counter+" times");
            //    counter = 1;

            //}

            #endregion
            #region Q15
            //Console.WriteLine("Enter size");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr1[0],
            //min = arr1[0];
            //for (int i = 0;i < size; i++) 
            //{
            //    if (max < arr1[i])
            //    {
            //        max = arr1[i];
            //    }

            //    if (min > arr1[i])
            //    {
            //        min = arr1[i];
            //    }
            //}
            //Console.WriteLine("Max Number = "+max+" and Min Number = "+min);

            #endregion
            #region Q16
            //Console.WriteLine("Enter size");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size];
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr1[0];
            //int SecMax=0;
            //for (int i = 1; i < size; i++) 
            //{
            //    if (arr1[i] > max)
            //    {
            //        SecMax=max;
            //        max = arr1[i];

            //    }
            //    else if (arr1[i] > SecMax && arr1[i] != max) 
            //    {
            //        SecMax = arr1[i];
            //    }

            //}
            //Console.WriteLine("Second Max Number = "+SecMax.ToString());
            #endregion
            #region Q17
            //Console.WriteLine("Enter size");
            //int size = int.Parse(Console.ReadLine());
            //string[] arr1 = new string[size];
            //int MaxDistance = 0;
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = Console.ReadLine();
            //}
            //foreach (string i in arr1) {
            //Console.Write(" "+i+" ");
            //}
            //Console.WriteLine(); 
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr1[i] == arr1[j])
            //        {
            //            int dis = j - i -1;
            //            if (dis > MaxDistance) 
            //            {
            //                MaxDistance = dis; 
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("Max distance = "+MaxDistance); 

            #endregion
            #region Q18
            //Console.WriteLine("Enter String");
            //string input = Console.ReadLine();
            //string[] SplitInput = input.Split(' ');
            //string[] Reverse = new string[SplitInput.Length];
            //for (int i = 0; i < SplitInput.Length; i++) 
            //{
            //    Reverse[i] = SplitInput[SplitInput.Length - 1-i];
            //}
            //foreach (string s in Reverse)
            //{
            //    Console.Write(" "+s+" ");
            //}

            #endregion
            #region Q19
            //Console.WriteLine("enter the num of rows");
            //int row=int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the num of columns");
            //int column = int.Parse(Console.ReadLine());
            //int [,]Arr=new int [row,column];
            //int[,] CopyArr = new int [row,column];   
            //Console.WriteLine("Enter the elements of array");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Arr[i,j] =int.Parse( Console.ReadLine());
            //    }   
            //}
            //Console.WriteLine("the array is ");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(" "+Arr[i,j] +" ");

            //    }
            //    Console.WriteLine();
            //}
            ////Second Solution
            ////Array.Copy(Arr, CopyArr, Arr.Length);
            ////for (int i = 0; i < row; i++)
            ////{
            ////    for (int j = 0; j < column; j++)
            ////    {
            ////        CopyArr[i,j]=Arr[i,j];

            ////    }
            ////}
            //Console.WriteLine("the CopyArray is ");
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(" " + CopyArr[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}



            #endregion
            #region Q20
            //Console.WriteLine("Enter size");
            //int size = int.Parse(Console.ReadLine());
            //string[] arr1 = new string[size];
            //string[] ReverseArr = new string[size];
            //int MaxDistance = 0;
            //Console.WriteLine("Enter the Arr");
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = Console.ReadLine();
            //}
            //Console.WriteLine("The Original Arr");
            //Console.WriteLine(string.Join(" ", arr1));
            //for (int i = 0; i < size; i++)
            //{
            //    ReverseArr[i] = arr1[size-1-i];
            //}
            //Console.WriteLine("The Reverse Arr");
            //Console.WriteLine(string.Join(" ",ReverseArr));

            #endregion
        }
    }
}
