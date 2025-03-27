using System.Numerics;

namespace CalculadoraConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // programação estruturada = trabalho com funções
            // refatoração
            
            string[] operacoesRealizadas = new string[100];
            int contadorHistorico = 0;

            while (true)
            {
                string opcao = ExibirMenu(); 

                if (OpcaoSairFoiEscolhida(opcao))
                {
                    break;
                }
                else if (OpcaoTabuadaFoiEscolhida(opcao))
                {
                    ExibirTabuada();
                }
                else if (OpcaoHistoricoFoiEscolhida(opcao))
                {
                    ExibirHistoricoOperacoes(contadorHistorico, operacoesRealizadas);
                }
                else
                {
                    decimal resultado =  RealizarCalculo(opcao, contadorHistorico, operacoesRealizadas);
                    ExibirResultado(resultado);
                }
                Console.ReadLine();
            }
        }

        static string ExibirMenu()
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
            Console.WriteLine("6 - Historico de operações");
            Console.WriteLine("S - Sair");
            string opcao = Console.ReadLine();

            return opcao;
        }

        static bool OpcaoSairFoiEscolhida(string opcao)
        {
            bool opcaoSairFoiEscolhida = opcao == "S";
            return opcaoSairFoiEscolhida;
        }

        static bool OpcaoTabuadaFoiEscolhida(string opcao)
        {
            bool opcaoTabuadaFoiEscolhida = opcao == "5";
            return opcaoTabuadaFoiEscolhida;
        }

        static void ExibirTabuada()
        {
            Console.WriteLine("Qual numero da Tabuada?");
            int numeroTabuada = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                string linhaDaTabuada = numeroTabuada + " X " + contador + " = " + numeroTabuada * contador;
                Console.WriteLine(linhaDaTabuada);


            }
            Console.ReadLine();

        }

        static bool OpcaoHistoricoFoiEscolhida(string opcao)
        {
            return opcao == "6";
        }

        static void ExibirHistoricoOperacoes(int contadorHistorico, string[] operacoesRealizadas)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Histórico de Operações");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < operacoesRealizadas.Length; i++)
            {
                if (operacoesRealizadas[i] != null)
                    Console.WriteLine(operacoesRealizadas[i]);
            }

            Console.ReadLine();
        }

        static decimal RealizarCalculo(string opcao, int contadorHistorico, string[] operacoesRealizadas)
        {
            bool divisaoZerada = false;

            Console.Write("Digita o Primeiro número: ");
            decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());


            Console.Write("Digita o Segundo número: ");
            decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = 0;
            // estrutura de decisao

            if (opcao == "1")
            {

                resultado = primeiroNumero + segundoNumero;
                operacoesRealizadas[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
            }
            else if (opcao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
                operacoesRealizadas[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

            }
            else if (opcao == "3")
            {
                if (segundoNumero == 0)
                {
                    Console.WriteLine("Impossivel divisão po ZERO!");
                    divisaoZerada = true;

                }
                else if (divisaoZerada == false)
                {
                    resultado = primeiroNumero / segundoNumero;
                    operacoesRealizadas[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                }
            }
            else if (opcao == "4")
            {
                resultado = primeiroNumero * segundoNumero;
                operacoesRealizadas[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

            }
            contadorHistorico++;
            return resultado;
        }

        static void ExibirResultado(decimal resultado)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("-----------------------");

            Console.Write("Deseja continuar? (S/N): ");
            
        }
        
    }
}
