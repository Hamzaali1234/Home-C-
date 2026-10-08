// home 1
// string Sanj(int a)
// {
//     if(a > 10)
//     {
//         return "True";
//     }
//     else
//     {
//         return "False";
//     }
// }
// System.Console.WriteLine(Sanj(9));



// home 2
// string Palindrome(int a)
// {
//     int b = 0;
//     for (int i = a; i > 0; i /= 10)
//     {
//         b = b*10+i%10;
//     }
//     if(b==a) return "Yes";
//     else
//     {
//         return "No";
//     }
// }
// System.Console.WriteLine(Palindrome(121));



// home 3
//  int SumOfTwoNums(int a, int b)
// {
//     return a+b;
// }
// System.Console.WriteLine(SumOfTwoNums(3,5));


// home 4
// int chislo(int a)
// {
//     return a+1;
// }
// System.Console.WriteLine(chislo(5));



// home 5
// double ploshad(double a, double b)
// {
//     return a*b/2;
// }
// System.Console.WriteLine(ploshad(10,5));



// home 6
// int AgeInYear(int a)
// {
//      return a * 365;
// }
// System.Console.WriteLine(AgeInYear(2));



// home 7
// int Age(int a)
// {
//   if(a > 18 && a < 100)
//     {
//         Console.WriteLine($"Добро пожаловать, вам {a} лет, и вы можете работать");
//         return 0;
//  }

//     else
//     {
//         Console.WriteLine($"Здравствуйте, вам {a} лет, и вы не можете работать");
//         return 0;
//     }
// }
// System.Console.WriteLine(Age(40));


// home 8
// int SumOfNumbers (int a)
// {
//     int sum=0;
//     for (int i = 0; i <= a; i++)
//     {
//          sum+=i;
//     }
//     return sum;
// }
// System.Console.WriteLine(SumOfNumbers(4));



// home 9
// int MinDigit (int n)
// {
//     int min = int.MaxValue;
//     for (int i=n; i>0;i/=10)
//     {
//         if((i%10) < min) min = i % 10;
//     }
//     return min;
// }
// System.Console.WriteLine(MinDigit(375));


//  int MaxDigit (int n)
// {
//     int max = int.MinValue;
//     for (int i = n; i > 0; i/=10)
//     {
//         if((i%10) > max) max = i % 10;
//     }
//     return max;
// }
// System.Console.WriteLine(MaxDigit(375));



// tack 10
// int Digitsd (int a)
// {
//     int cnt = 0;
//     for (int i = 0; i <=a; i/=10)
//     {
//         if(i==a) cnt++;
//     }
//     return cnt;
// }
// System.Console.WriteLine(Digitsd(101));


// tack 11
// int FindMinimum(int a, int b, int c, int d)
// {
//     int min = a;
//     if(b < min)
//     {
//         min = b;
//     }
//     if(c < min)
//     {
//         min = c;
//     }
//     if(d < min)
//     {
//         min = d;
//     }
//     return min;
// }
// System.Console.WriteLine(FindMinimum(8,-11,4,9));



// tack 12
//  float AverageOfNumbers(int a, int b, int c, int d)
// {
//     return (a + b + c + d) / 4.0f;
// }
// System.Console.WriteLine(AverageOfNumbers(1,2,3,4));


// tack 13
// double FindPerimeter(char figure, double num)
// {
     
// }


// tack 14
// int ConvertToSeconds(int a)
// {
//     return a * 60;
// }
// System.Console.WriteLine(ConvertToSeconds(20));


// tack 15
// char CheckGrade (int grade)
// {
//     if(grade >= 90)
//     {
//         return 'A';
//     }
//     if(grade >= 80)
//     {
//         return 'B';
//     }
//      if(grade >= 70)
//     {
//         return 'C';
//     }
//     if(grade >= 60)
//     {
//         return 'D';
//     }
//     else
//     {
//         return'F';
//     }
// }
// System.Console.WriteLine(CheckGrade(90));


// tack 16
// long  GetCube(int a)
// {
//     return a * a * a;
// }
// System.Console.WriteLine(GetCube(2));




// long GetCube(int a)
// {
//     return a * a;
// }
// System.Console.WriteLine(GetCube(5));