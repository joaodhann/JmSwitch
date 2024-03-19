using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JmSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");

            double um = double.Parse(Console.ReadLine());    

            Console.WriteLine("Digite o segundo número");

            double dois = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação");

            string operacao = Console.ReadLine().ToUpper();   

            switch (operacao)
            {
                case "+":
                     double resultado = um + dois;
                     Console.WriteLine("O resultado é: " + resultado); 
                        break;
                case "-":
                    double resultado2 = um - dois;
                    Console.WriteLine("O resultado é: " + resultado2);
                    break;
                case "*":
                    double resultado3 = um * dois;
                    Console.WriteLine("O resultado é:" + resultado3);
                    break;
                case "/":
                    double resultado4 = um / dois;
                    Console.WriteLine("O resultado é: " + resultado4);
                    break;
                default:
                    Console.WriteLine("ERRO, OPÇÃO INVÁLIDA");
                    break;
            }
               Console.ReadKey();
            
        }
    }
}
