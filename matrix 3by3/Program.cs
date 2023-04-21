using System;
namespace project
{
    class test
    {
    public static void Main()
    {
            int[,] a = new int[3, 3];
            
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("miane");
            Calc(a);
    }
    private static void Calc(int [,]a)
    {

            
            
            for (int i=1;i<=1;i++)
            {
            for(int j=1;j<=1;j++)
            {
              a[i, j] =(( a[i-1, j - 1] + a[i, j] + a[i+1, j+ 1])/3);
                   
            }
               
                
            }
      for(int i=0;i<3;i++)
            { for(int j=0;j<3;j++)
                {

                    Console.WriteLine(a[i, j]);
                }
            }
    }
    }
}