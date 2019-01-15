using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyDiler
{
    class SingletonObjectContext
    {

        private static readonly SingletonObjectContext instance = new SingletonObjectContext();
        private readonly DBEntities context;

        private SingletonObjectContext()
        {
            context = new DBEntities();
        }

        public static SingletonObjectContext Instance
        {
            get
            {
                return instance;
            }
        }

        public DBEntities Context
        {
            get
            {
                return context;
            }
        }

    }
}
