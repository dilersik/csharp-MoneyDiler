using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MoneyDiler
{
    class FinanceDAO
    {

        public static bool Insert(Finance financeVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeVO.Status = SystemU.STATUS_ATIVO;
                financeVO.DatePost = DateTime.Now;
                financeVO.DateUpdate = DateTime.Now;
                db.Finances.Add(financeVO);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Finance financeVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeVO.DateUpdate = DateTime.Now;
                db.Entry(financeVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateDisable(Finance financeVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeVO.Status = financeVO.Status * -1;
                financeVO.DateUpdate = DateTime.Now;
                db.Entry(financeVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static IOrderedEnumerable<Finance> ListAllBy(Finance financeVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            if (financeVO.FinanceCategorySub.FinanceCategory.Id > 0)
                return db.Finances.Include("FinanceCategorySub.FinanceCategory").Where(x => x.Status > 0 && x.FinanceCategorySub.FinanceCategory.Id.Equals(financeVO.FinanceCategorySub.FinanceCategory.Id)).ToList().OrderByDescending(x => x.Date);
            if (financeVO.FinanceCategorySub.Id > 0)
                return db.Finances.Include("FinanceCategorySub.FinanceCategory").Where(x => x.Status > 0 && x.FinanceCategorySub.Id.Equals(financeVO.FinanceCategorySub.Id)).ToList().OrderByDescending(x => x.Date);

            return db.Finances.Include("PaymentForm").Include("FinanceCategorySub.FinanceCategory").Where(x => x.Status > 0 && x.FinanceCategorySub.FinanceCategory.Type.Equals(financeVO.FinanceCategorySub.FinanceCategory.Type)).ToList().OrderByDescending(x => x.Date);
        }

        public static List<Finance> ListByFilter(Finance f, DateTime dateIn, DateTime dateEnd)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            
            return db.Finances.Where(x => x.Status > 0 && x.FinanceCategorySub.FinanceCategory.Type.Equals(f.FinanceCategorySub.FinanceCategory.Type) && x.PaymentForm.Id.Equals(f.PaymentForm.Id) && x.Date >= dateIn && x.Date <= dateEnd).ToList();
        }

        public static Finance GetByID(Finance financeVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.Finances.FirstOrDefault(x => x.Id.Equals(financeVO.Id) && x.Status > 0);
            }
            catch
            {
                return null;
            }
        }

    }
}
