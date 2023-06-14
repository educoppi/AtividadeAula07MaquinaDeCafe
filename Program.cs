using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula07MaquinaDeCafe
{
    internal class Program
    {
        /**
         * Dado o desafio seguinte:
         * 
         * Extra: de forma não obrigatória, se você quiser tentar algo mais difícil, faça com que ao reiniciar o sistema da
         * máquina, o valor que tenha sobrado do cliente anterior não seja perdido. Exemplo: o cliente depositou R$ 3,05 e
         * comprou um café que custa R$ 3,00. Após reiniciar o sistema, os centavos R$ 0,05 devem continuar existindo.
         * 
         * 
         * Encontrei como solução para o desafio utilizar uma variável global "valorNaMaquina" e uma variável local "valorAuxiliar".
         **/
        
        // Variável global para armazenar o valor que sobrar na máquina.
        public static double valorNaMaquina = 0;


        static void Main(string[] args)
        {
            double cafeExpresso = 3.00;
            double capuccino = 4.50;
            double mocaccino = 6.00;
            double aguaQuente = 1.00;

            double pagamento;
            int opcao;

            double valorAuxiliar;
            
            //"valorNaMaquina.ToString("C")" converte o valor dessa variável em string e a transforma em valor monetário (R$ 0,00).
            Console.WriteLine("\n___________________________________");
            Console.WriteLine("\nBem-vindo ao CaféJá");
            Console.WriteLine($"Valor na máquina: {valorNaMaquina.ToString("C")}");
            Console.WriteLine("\n___________________________________");
            Console.WriteLine($"1 - Café expresso           {cafeExpresso.ToString("C")}");
            Console.WriteLine($"2 - Capuccino               {capuccino.ToString("C")}");
            Console.WriteLine($"3 - Mocaccino               {mocaccino.ToString("C")}");
            Console.WriteLine($"4 - Água quente             {aguaQuente.ToString("C")}");
            Console.WriteLine("___________________________________");
            Console.Write("Selecione uma das opções de café: ");
            opcao = int.Parse(Console.ReadLine());

            if ((opcao < 1) || (opcao > 4))
            {
                Console.WriteLine("Opção inválida");
                Console.WriteLine("Pressione ENTER para reiniciar");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.Write("Agora insira o pagamento: ");
            pagamento = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("___________________________________\n");

            valorAuxiliar = valorNaMaquina + pagamento;

            /** 
             * 
             * Variável Local - "valorAuxiliar"
             * 
             * 1 - "ValorAuxiliar" é usado para saber se o valor que há na máquina somado ao pagamento é igual ou superior ao preço.
             * Caso seja verdadeiro, ele é usado numa subtração com o preço para retirar o que sobrou e então armazenar em "valorNaMaquina".
             * 
             * 2 - Caso "valorAuxiliar" seja menor que o preço, esse valor que está dentro da minha variável local
             * é descartado quando reinicia o Main, como se a máquina devolvesse o dinheiro ao consumidor.
             * 
             * **/
            if (opcao == 1)
            {
                if (valorAuxiliar >= cafeExpresso)
                {

                    valorNaMaquina = valorAuxiliar - cafeExpresso;

                    Console.WriteLine("Preparando Café Expresso...");
                }
                else
                {
                    Console.WriteLine("Valor insuficiente!");
                    Console.WriteLine("Pressione ENTER para reiniciar");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
                    return;
                }
            }

            if (opcao == 2)
            {
                if (valorAuxiliar >= capuccino)
                {

                    valorNaMaquina = valorAuxiliar - capuccino;

                    Console.WriteLine("Preparando Capuccino...");
                }
                else
                {
                    Console.WriteLine("Valor insuficiente!");
                    Console.WriteLine("Pressione ENTER para reiniciar");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
                    return;
                }
            }

            if (opcao == 3)
            {
                if (valorAuxiliar >= mocaccino)
                {

                    valorNaMaquina = valorAuxiliar - mocaccino;

                    Console.WriteLine("Preparando Mocaccino...");
                }
                else
                {
                    Console.WriteLine("Valor insuficiente!");
                    Console.WriteLine("Pressione ENTER para reiniciar");
                    Console.ReadKey(); ;
                    Console.Clear();
                    Main(null);
                    return;
                }
            }

            if (opcao == 4)
            {
                if (valorAuxiliar >= aguaQuente)
                {

                    valorNaMaquina = valorAuxiliar - aguaQuente;

                    Console.WriteLine("Preparando Água Quente...");
                }
                else
                {
                    Console.WriteLine("Valor insuficiente!");
                    Console.WriteLine("Pressione ENTER para reiniciar");
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
                    return;
                }
            }

            Console.WriteLine("\n___________________________________\n");
            Console.WriteLine("Sua bebida está pronta!");
            Console.WriteLine("Pressione ENTER para encerrar");
            Console.ReadKey();
            Console.Clear();
            Main(null);
            return;
        }
    }
}
