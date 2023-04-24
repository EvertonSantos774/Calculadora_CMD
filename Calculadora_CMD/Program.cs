using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_CMD
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplacacao, Potencia, Raiz, Sair}

        static void Main(string[] args)
        {

            bool escolheuSair = false;
            while (!escolheuSair)
            {
                //Txt de apresentação
                Console.WriteLine("Seja bem vindo ao CALC, selecione uma das opções: \n");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                //Conversão da seleção do usuario
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                
                //Seleção de operação
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplacacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potecia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }

                Console.Clear();

            }
            
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois numeros: ");
            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Potecia()
        {
            Console.WriteLine("Potencia de um numeros: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int exp = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, exp);
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um numeros: ");
            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O Resultado é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }
    }
}
