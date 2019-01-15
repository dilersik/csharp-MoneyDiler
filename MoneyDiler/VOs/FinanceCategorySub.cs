using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class FinanceCategorySub
    {

        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DateUpdate { get; set; }
        public string Name { get; set; }
        public virtual FinanceCategory FinanceCategory { get; set; }
        public virtual ICollection<Finance> collFinance { set; get; }

    }
}
