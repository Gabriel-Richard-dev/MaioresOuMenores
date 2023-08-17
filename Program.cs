using System;
using System.Net.Sockets;

namespace MaioresOuMenores
{
    class Program
    {
        public static int cacheMaior, cacheMenor, valor;
        public static short controle = 0;
        
        static void Main(string[] args)
        {
            Menu();
        }



        static void Menu()
        {
            
            
            InsereValor();
            
            if (controle == 0)
            {
                cacheMaior = valor;
                cacheMenor = valor;
                controle++;
            }
            else if(valor != 0)
            {
                CompareTo((int)Option.Menor);
                CompareTo((int)Option.Maior);
            }

            switch (valor)
            {
                case 0: Final(); break;
                default: Menu(); break;
            }
            
        }
        static void InsereValor()
        {
            
            Console.Write("Informe um número (0 para sair): ");
            string? txt = Console.ReadLine();
            
            if (txt is not null) {
                try
                {
                    valor = int.Parse(txt);
                }
                catch
                {
                    Console.WriteLine("Por favor insira um valor inteiro :)");
                    InsereValor();
                }
                
            }
            
        }

        static void CompareTo(int option)
        {
            
            //1 = maior , 0 = menor
            
            switch (option)
            {
                case 0:
                {
                    if (valor < cacheMenor)
                        cacheMenor = valor;
                    break;
                }
                default:
                {
                    if (valor > cacheMaior)
                        cacheMaior = valor;
                    break;
                }
                
            }
            

        }


        static void Final()
        {
            Console.WriteLine($"O maior valor é: {cacheMaior}");
            Console.WriteLine($"O menor valor é: {cacheMenor}");
        }
        
        public enum Option
        {

            Menor,
            Maior
    }
        
        
        
    }
}