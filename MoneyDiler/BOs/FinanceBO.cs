using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class FinanceBO
    {

        public static double CalcSaldo(double ganhos, double gastos)
        {
            return ganhos - gastos;
        }

    }
}
