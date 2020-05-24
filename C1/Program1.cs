using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             /*Console.WriteLine("podaj liczbe 1:");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbe 2:");
            int l2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj liczbe 3:");
            int l3 = Convert.ToInt32(Console.ReadLine());
            int min = l1;
            if (l2 < min)
                min = l2;
            if (l3 < min)
                min = l3;
            Console.WriteLine("Minimum to {0}", min);
            int max = l1;
            if (l2 > max)
                max = l2;
            if (l3 > max)
                max = l3;
            Console.WriteLine("Maximum to {0}", max);
                double średnia = (l1 + l2 + l3) / 3;
            Console.WriteLine("średnia to {0}", średnia);
            Console.ReadKey()*/




/* Console.WriteLine("podaj rok");
 int rok = Convert.ToInt32(Console.ReadLine());
 if (((rok%400 == 0) && (rok%100 !=0))  || (rok%400 == 0))
 Console.WriteLine("rok {0} przystepny", rok);
 else
 Console.WriteLine("rok {0} nie przystepny", rok);
 Console.ReadKey();
}*/
/*  Console.WriteLine("podaj liczbę od 1 do 12");
  int miesiac = Convert.ToInt32(Console.ReadLine());
  switch (miesiac)
  {
      case 1:
          Console.WriteLine("Styczeń");
          break;
      case 2:
          Console.WriteLine("luty");
          break;
      case 3:
          Console.WriteLine("marzec");
          break;
      case 4:
          Console.WriteLine("kwiecien");
          break;
      case 5:
          Console.WriteLine("maj");
          break;
      case 6:
          Console.WriteLine("czerwiec");
          break;
      case 7:
          Console.WriteLine("lipiec");
          break;
      case 8:
          Console.WriteLine("sierpien");
          break;
      case 9:
          Console.WriteLine("wrzesien");
          break;
      case 10:
          Console.WriteLine("pazdziernik");
          break;
      case 11:
          Console.WriteLine("listopad");
          break;
      case 12:
          Console.WriteLine("grudzien");
          break;
      default: Console.WriteLine("to juz nie miesiac");
          break;
  }
  Console.ReadKey();*/


//  Console.WriteLine("Podaj liczbę");
//int liczba = Int32.Parse(Console.ReadLine());
//for (int i = 0; i <= liczba; i++) 
//Console.WriteLine("{0}, ", Math.Pow(2, i)); 
// Console.ReadKey();


//                int n, suma=0;
//    Console.WriteLine("podaj");
//    if (Int32.TryParse(Console.ReadLine(), out n))
//        for (int i = 1; i <= n; i++)
//            suma += i;
//   Console.WriteLine("1 + ... + {0}={1},",n, suma);
//    Console.ReadKey();


/* for (int j = 1; j <=1000; j++)
    {
        for (int i = 1; i <= 1000; i++)
            Console.Write(i*j + " ");
            Console.WriteLine();
     }
    Console.ReadKey();
*/


/*   for (int i = 1; i <= 1000; i++)
   {
       if (i % 3 ==0 || i % 11==0  || i % 5==0) 
       Console.WriteLine(i);
   }
   Console.ReadKey();
  for (int j = 0; j <= 10; j++)
     {
         for (int i = 0; i < j; i++)
             Console.Write("*\t", i*j);
         Console.WriteLine();
     }
Console.WriteLine();

     for (int i = 10; i > 0; i--)
     {
         for (int j = 0; j < i; j++)
             Console.Write("*\t", i * j);
         Console.WriteLine();
     }

     for (int j =0; j < 10; j++)
     {for (int i =0; i<j; i++)
             Console.Write("\t");
         for (int i = 10; i > j; i--)
             Console.Write("*\t", i * j);
         Console.WriteLine();
     }*/
}
}
}
