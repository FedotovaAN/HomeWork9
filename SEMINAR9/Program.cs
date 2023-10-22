// Задача 1 , задайте значение N. Напишите программу, котрая выведет все натуральные числа в промежутке от 1
// до N
// N=5 -> 1 2 3 4 5
// N=6 -> 1 2 3 4 5 6

//void ShowNums(int n)
//{
    //if (n>0)
    //{
        //ShowNums(n-1);
        //System.Console.Write(n + " ");
    //}
//}
//ShowNums(5);

// напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// 453-> 12
// 45-> 9

//int FindSum(int num)
//{
   //if(num > 0)
   //{
     // return FindSum(num/ 10) + num %10;
   //}
   //else return num;
//}

//System.Console.WriteLine(FindSum(453));

// Напишите программу, которая выведет все натуральные числа в промежутке от M до N
// M=1; N=5 -> 1 2 3 4 5 
// M=4 N=8 -> 4 5 6 7 8

//void NumsFromTo(int m, int n)
//{
    //if (m != n)
    //{
       //if (m > n)
      //{
         //NumsFromTo(m-1, n);
         //System.Console.Write(m + " ");
      //}
    //else 
      //{
         //NumsFromTo(m, n-1);
         //System.Console.Write(n + " ");  
      //}
    //}
    //else System.Console.Write(m + " ");
//}
//NumsFromTo(10, 5);

//Напишите програму, которая на вход принимает два числа А и В, и возводит число А в целую степень В
//А=3 В=5 -> 243 (3 степень 5)
//А=2 В=3 -> 8

int Exponentiation (int a, int b)
{
   if (b >=1)
   {
     return Exponentiation(a, b-1) *a;
   }
   else return 1;
}

System.Console.Write(Exponentiation(2, 3));


