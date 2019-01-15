using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class Finance
    {

        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DateUpdate { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateClose { get; set; }
        public int Situation { get; set; }
        public int Priority { get; set; }
        public string Text { get; set; }
        public virtual FinanceCategorySub FinanceCategorySub { get; set; }
        public virtual PaymentForm PaymentForm { get; set; }

    }
}
