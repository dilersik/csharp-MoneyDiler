using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class FinanceU
    {

        public static String[] ArraySituation =
        {
            "", "Pago", "Pendente"
        };
        public const int SITUATION_PAGO = 1, SITUATION_PENDENTE = 2;
        public static String[] ArrayRepeat =
        {
            "", "Não se repete", "Diário", "Semanal", "Quinzenal", "Mensal", "Bimestral", "Trimestral", "Semestral", "Anual"
        };
        public const int REPEAT_NONE = 1, REPEAT_DIARIO = 2, REPEAT_SEMANAL = 3, REPEAT_QUINZENAL = 4, REPEAT_MENSAL = 5, REPEAT_BIMESTRAL = 6, REPEAT_TRIMESTRAL = 7,
                         REPEAT_SEMESTRAL = 8, REPEAT_ANUAL = 9;
        public static String[] ArrayPriority =
        {
            "", "Normal", "Baixa", "Média", "Alta"
        };
        public const int PRIORITY_NORMAL = 1, PRIORITY_BAIXA = 2, PRIORITY_MEDIA = 3, PRIORITY_ALTA = 4;

    }
}
