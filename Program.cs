using System;

namespace programa_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
                  double numero2;
                  double total;
                  double numero3;                   

                  Console.WriteLine("digite o numero 1");
                  numero1 = Convert.ToDouble( Console.ReadLine() );

                   Console.WriteLine("digite o numero 2");
                  numero2 = Convert.ToDouble(Console.ReadLine() );


                  total = numero1 * numero2;

                  Console.WriteLine("a soma dos numeros é: " + total );
                  
                  Console.WriteLine("agora divida o valor ");
                  numero3 = Convert.ToDouble(Console.ReadLine());

                  total = total / numero3;

                  Console.WriteLine("a divisão do resultado é " + total);


                  Console.ReadKey();
                  



        
            




           
      
        }
    }
}
