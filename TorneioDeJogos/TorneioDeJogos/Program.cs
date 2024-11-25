using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioDeJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string nickname = "";
            int ranking = 0;
            string jogoPreferido = "";
            bool valorValido = false;

            try
            {
                // Primeiro laço: validação do nickname
                while (!valorValido)
                {
                    Console.Write("Digite seu nickname ou 'S' para sair: ");
                    nickname = Console.ReadLine();

                    if (nickname.ToUpper() == "S")
                    {
                        Console.WriteLine("\nInscrição cancelada.\n");
                        return;
                    }

                    if (!string.IsNullOrWhiteSpace(nickname))
                    {
                        valorValido = true; // Nickname válido
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERRO: Nickname não pode estar vazio.\n");
                        Console.ResetColor();
                    }
                }

                // Reseta o controle para o próximo laço
                valorValido = false;

                // Segundo laço: validação do ranking
                while (!valorValido)
                {
                    Console.Write("Digite seu ranking (entre 100 e 3000) ou 'S' para sair: ");
                    string rankingDigitado = Console.ReadLine();

                    if (rankingDigitado.ToUpper() == "S")
                    {
                        Console.WriteLine("\nInscrição cancelada.\n");
                        return;
                    }

                    try
                    {
                        ranking = int.Parse(rankingDigitado);

                        if (ranking < 100 || ranking > 3000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nERRO: Insira um ranking válido entre 100 e 3000.\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            valorValido = true; // Ranking válido
                        }
                    }
                    catch (FormatException)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nErro: Por favor, digite um número válido para o ranking.\n");
                        Console.ResetColor();
                    }
                }

                // Reseta o controle para o próximo laço
                valorValido = false;

                // Terceiro laço: validação do jogo preferido
                while (!valorValido)
                {
                    Console.Write("Digite seu jogo preferido (FPS, RPG, MOBA) ou 'S' para sair: ");
                    jogoPreferido = Console.ReadLine();

                    if (jogoPreferido.ToUpper() == "S")
                    {
                        Console.WriteLine("\nInscrição cancelada.\n");
                        return;
                    }

                    jogoPreferido = jogoPreferido.Trim().ToUpper();

                    if (jogoPreferido == "FPS" || jogoPreferido == "RPG" || jogoPreferido == "MOBA")
                    {
                        valorValido = true; // Jogo preferido válido
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERRO: Escolha válida: FPS, RPG ou MOBA.\n");
                        Console.ResetColor();
                    }
                }

                // Verificar elegibilidade
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n--- Inscrição Concluída ---");
                Console.WriteLine($"Nickname: {nickname}");
                Console.WriteLine($"Ranking: {ranking}");
                Console.WriteLine($"Jogo Preferido: {jogoPreferido}");

                if (ranking >= 1000)
                {
                    Console.WriteLine("\nParabéns! Você está qualificado para o torneio!");
                }
                else
                {
                    Console.WriteLine("\nInfelizmente, seu ranking ainda não é suficiente para o torneio.");
                }
                Console.ResetColor();
            }
            finally
            {
                Console.WriteLine("\nObrigado por participar!");
                Console.ReadKey();
            }
        }
    }
}
