using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class FinanceCategory
    {

        public int Id { get; set; }
        public int Status { get; set; }
        public DateTime DatePost { get; set; }
        public DateTime DateUpdate { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public virtual ICollection<FinanceCategorySub> collFinanceCategorySub { set; get; }

    }
}
