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
            do
            {
                Console.WriteLine("Informe o que deseja fazer: ");
                Console.WriteLine("Saque - 1, Depósito - 2, Pagamento - 3 ou Consulta - 4 ");
                double type = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        saque(saldo);
                        break;


                    case 2:
                        deposito(saldo);
                        break;

                    case 3:
                        pagamento(saldo);
                        break;

                    case 4:
                        consulta(saldo);
                        break;
                }



                Console.WriteLine("Você deseja continuar? [0 - sim / 1 - não]");
                resp = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (resp == 0);
            
            
            Console.ReadKey();

        }
        //acabou o corpo principal
        //fun de saque:
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

        //fun de deposito
        static void deposito(double v1)
        {
            Console.WriteLine("Informe o valor que deseja depositar: ");
            double ValDep = double.Parse((Console.ReadLine()));

            v1 = v1 + ValDep;
            
            Console.ReadKey();
        }
        //acabou a fun de deposito
        //começue a fun de pagamento
        static void pagamento(double v1)
        {
            Console.WriteLine("Informe o valor que deseja pagar: ");
            double ValPag = double.Parse((Console.ReadLine()));

            if (ValPag < v1)
            {
                v1 = v1 - ValPag;
                Console.WriteLine("Seu pagamento foi efetuado com sucesso! ");
                Console.WriteLine("Seu novo saldo é de : " + v1);
            }

            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
        //acabou a fun de pagamento

        //começo da fun de consulta:
        static void consulta(double v1)
        {
            Console.WriteLine("Seu saldo é de: " + v1);

            Console.ReadKey();
        }
    }


}
