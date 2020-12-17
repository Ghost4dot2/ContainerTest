using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    interface Database
    {
        // If ID already exists it will replace it
        public void add(DB_Object newItem, bool saveAfterAdd = true);
        public void remove(String ID);
        public T getObject<T>(String ID);
    }
}
