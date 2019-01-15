using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MoneyDiler
{
    class FinanceCategorySubDAO
    {

        public static bool Insert(FinanceCategorySub financeCategorySubVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeCategorySubVO.Status = SystemU.STATUS_ATIVO;
                financeCategorySubVO.DatePost = DateTime.Now;
                financeCategorySubVO.DateUpdate = DateTime.Now;
                db.FinanceCategoriesSubs.Add(financeCategorySubVO);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(FinanceCategorySub financeCategorySubVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeCategorySubVO.DateUpdate = DateTime.Now;
                db.Entry(financeCategorySubVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateDisable(FinanceCategorySub financeCategorySubVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                financeCategorySubVO.Status = financeCategorySubVO.Status * -1;
                financeCategorySubVO.DateUpdate = DateTime.Now;
                db.Entry(financeCategorySubVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static IOrderedEnumerable<FinanceCategorySub> ListAllBy(FinanceCategorySub financeCategorySubVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            if (financeCategorySubVO.FinanceCategory.Id > 0)
                return db.FinanceCategoriesSubs.Include("FinanceCategory").Where(x => x.Status > 0 && x.FinanceCategory.Id.Equals(financeCategorySubVO.FinanceCategory.Id)).ToList().OrderBy(x => x.Name);
            if (financeCategorySubVO.FinanceCategory.Type > 0)
                return db.FinanceCategoriesSubs.Include("FinanceCategory").Where(x => x.Status > 0 && x.FinanceCategory.Type.Equals(financeCategorySubVO.FinanceCategory.Type)).ToList().OrderBy(x => x.Name);

            return db.FinanceCategoriesSubs.Include("FinanceCategory").Where(x => x.Status > 0).ToList().OrderBy(x => x.Name);
        }

        public static FinanceCategorySub GetByID(FinanceCategorySub financeCategorySubVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.FinanceCategoriesSubs.FirstOrDefault(x => x.Id.Equals(financeCategorySubVO.Id) && x.Status > 0);
            }
            catch
            {
                return null;
            }
        }

        public static int CountByName(FinanceCategorySub financeCategorySubVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.FinanceCategoriesSubs.Count(x => x.Id != financeCategorySubVO.Id && x.Status > 0 && x.FinanceCategory.Id.Equals(financeCategorySubVO.FinanceCategory.Id) && x.Name.Equals(financeCategorySubVO.Name));
            }
            catch
            {
                return 0;
            }
        }

    }
}
