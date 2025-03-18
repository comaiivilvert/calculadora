using System.Numerics;

namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // V3 - Varias operações na calculadora
            // Loop de execução - While ou For
            //
            //DESAFIOS:
            //Multiplicação e Divisao - OK
            //Não pode permitir a divisão por zero - OK
            //Deve permitir realizar operações com numeros decimais (quebrados) - OK
            //Apresentar o resultado formatado - OK
            //


            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("CALCULADORA Tabajara 2025");
                Console.WriteLine("-------------------------");


                Console.WriteLine("Digita a opção desejada.");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Dividir");
                Console.WriteLine("4 - Multiplicar");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("S - Sair");
                string opcao = Console.ReadLine();
                bool divisaoZerada = false;


                if (opcao == "S")
                {
                    break;
                }
                
                else if (opcao == "5")
                {
                    Console.WriteLine("Qual numero da Tabuada?");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());
                    for (int contador=1;contador <=10; contador++)
                    {
                        string linhaDaTabuada = numeroTabuada + " X " + contador + " = " + numeroTabuada*contador;
                        Console.WriteLine(linhaDaTabuada);
                        

                    }
                    Console.ReadLine();
                    continue;

                }

                Console.Write("Digita o Primeiro número: ");
                string strPrimeiroNumero = Console.ReadLine();
                decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);
                

                Console.Write("Digita o Segundo número: ");
                string strSegundoNumero = Console.ReadLine();
                decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);
                


                decimal resultado = 0;
                // estrutura de decisao

                if (opcao == "1")
                {

                    resultado = primeiroNumero + segundoNumero;
                    Console.Write("O Resultado da soma é: ", resultado);
                    Console.WriteLine(resultado.ToString("F2"));
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    Console.Write("O Resultado da subtração é: ", resultado);
                    Console.WriteLine(resultado.ToString("F2"));

                }
                else if (opcao == "3")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Impossivel divisão po ZERO!");
                        divisaoZerada = true;
                    }
                    else if(divisaoZerada == false)
                    {
                        resultado = primeiroNumero / segundoNumero;
                        Console.Write("O Resultado da Divisão é: ", resultado);
                        Console.WriteLine(resultado.ToString("F2"));
                    }
                }
                else if (opcao == "4")
                {
                    resultado = primeiroNumero * segundoNumero;
                    Console.Write("O Resultado da Multiplicação é: ", resultado);
                    Console.WriteLine(resultado.ToString("F2"));

                }

                
                Console.ReadLine();
            }
            


            


        }
    }
}
