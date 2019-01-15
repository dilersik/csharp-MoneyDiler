using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MoneyDiler
{
    class PaymentFormDAO
    {

        public static bool Insert(PaymentForm paymentFormVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                paymentFormVO.Status = SystemU.STATUS_ATIVO;
                paymentFormVO.DatePost = DateTime.Now;
                paymentFormVO.DateUpdate = DateTime.Now;
                db.PaymentForms.Add(paymentFormVO);
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(PaymentForm paymentFormVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                paymentFormVO.DateUpdate = DateTime.Now;
                db.Entry(paymentFormVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateDisable(PaymentForm paymentFormVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                paymentFormVO.Status = paymentFormVO.Status * -1;
                paymentFormVO.DateUpdate = DateTime.Now;
                db.Entry(paymentFormVO).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static IOrderedEnumerable<PaymentForm> ListAll()
        {
            DBEntities db = SingletonObjectContext.Instance.Context;

            return db.PaymentForms.Where(x => x.Status > 0).ToList().OrderBy(x => x.Name);
        }

        public static PaymentForm GetByID(PaymentForm paymentoFormVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.PaymentForms.FirstOrDefault(x => x.Id.Equals(paymentoFormVO.Id) && x.Status > 0);
            }
            catch
            {
                return null;
            }
        }

        public static int CountByName(PaymentForm paymentFormVO)
        {
            DBEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.PaymentForms.Count(x => x.Id != paymentFormVO.Id && x.Status > 0 && x.Name.Equals(paymentFormVO.Name));
            }
            catch
            {
                return 0;
            }
        }

    }
}
