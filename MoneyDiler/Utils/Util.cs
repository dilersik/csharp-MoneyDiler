using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class Util
    {

        public static int Menu(String titulo, String[] opcoes)
        {
            int op = 0, i;

            while (true)
            {
                Console.WriteLine(titulo);
                for (i = 0; i < opcoes.Length; i++)
                    Console.WriteLine(i + ". " + opcoes[i]);

                Console.Write("Opcao: ");
                try
                {
                    op = int.Parse(Console.ReadLine());
                }
                catch
                {
                    op = -1;
                }

                if (op < 0 || op > opcoes.Length)
                    Console.Write("\nErro: Opcao invalida!\n\n");
                else
                    return op;
            }
        }

        public static string moneyFormat_ptBR(double n)
        {
            return "R$ " + n.ToString("N2");
        }

    }
}
