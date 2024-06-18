using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double saldo = 0;
            int resp = 0;

            Console.WriteLine("Informe o que deseja fazer: ");
            Console.WriteLine("Saque - 1, Depósito - 2, Pagamento - 3 ou Consulta - 4 ");
            double type = double.Parse(Console.ReadLine());
            
            switch (type)
            {
                case 1:
                    saque(saldo);

                break;
                    deposito(saldo);
                case 2:


                break;

                case 3:

                break;

                case 4:

                break;
            }
                
            
            
            
            
            
            
            Console.ReadKey();

        }
        //acabou o corpo principal

        static void saque(double v1)
        {
            Console.WriteLine("Informe o valor que deseja sacar: ");
            double ValSaq = double.Parse((Console.ReadLine()));

            if (ValSaq < v1)
            {
                v1 = v1 - ValSaq;
                Console.WriteLine("Seu Saque foi efetuado com sucesso! ");
                Console.WriteLine("Seu novo saldo é de : " + v1);
            }

            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

            Console.ReadKey();
        }
        //acabou a fun de saque 
        static void deposito(double v1)
        {
            Console.WriteLine("Informe o valor que deseja sacar: ");
            double ValSaq = double.Parse((Console.ReadLine()));

            if (ValSaq < v1)
            {
                v1 = v1 - ValSaq;
                Console.WriteLine("Seu Saque foi efetuado com sucesso! ");
                Console.WriteLine("Seu novo saldo é de : " + v1);
            }

            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

            Console.ReadKey();
        }
        //acabou a fun de deposito
    }

  
}
