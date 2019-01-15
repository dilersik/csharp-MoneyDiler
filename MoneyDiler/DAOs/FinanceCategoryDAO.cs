using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MoneyDiler
{
    class FinanceCategoryDAO
    {

        public static bool Insert(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeCategoryVO.Status = SystemU.STATUS_ATIVO;
                financeCategoryVO.DatePost = DateTime.Now;
                financeCategoryVO.DateUpdate = DateTime.Now;
                db.FinanceCategories.Add(financeCategoryVO);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeCategoryVO.DateUpdate = DateTime.Now;
                db.Entry(financeCategoryVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateDisable(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeCategoryVO.Status = financeCategoryVO.Status * -1;
                financeCategoryVO.DateUpdate = DateTime.Now;
                db.Entry(financeCategoryVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static IOrderedEnumerable<FinanceCategory> ListAll()
        {
            DBEntities db = SingletonObjectContext.Instance.Context;

            return db.FinanceCategories.Where(x => x.Status > 0).ToList().OrderBy(x => x.Name);
        }

        public static IOrderedEnumerable<FinanceCategory> ListByType(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;

            return db.FinanceCategories.Where(x => x.Status > 0 && x.Type.Equals(financeCategoryVO.Type)).ToList().OrderBy(x => x.Name);
        }

        public static IOrderedEnumerable<FinanceCategory> ListFinanceByType(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;

            return db.FinanceCategories.Include("collFinanceCategorySub").Include("collFinanceCategorySub.collFinance").Where(x => x.Status > 0 && x.Type.Equals(financeCategoryVO.Type)).ToList().OrderBy(x => x.Name);
        }

        public static FinanceCategory GetByID(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.FinanceCategories.FirstOrDefault(x => x.Id.Equals(financeCategoryVO.Id) && x.Status > 0);
            }
            catch
            {
                return null;
            }
        }

        public static int CountByName(FinanceCategory financeCategoryVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.FinanceCategories.Count(x => x.Id != financeCategoryVO.Id && x.Status > 0 && x.Type.Equals(financeCategoryVO.Type) && x.Name.Equals(financeCategoryVO.Name));
            }
            catch
            {
                return 0;
            }
        }

    }
}
