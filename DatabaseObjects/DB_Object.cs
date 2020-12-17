using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    public class DB_Object
    {
        public String ID { get; set; }

        public virtual void debug()
        {
            Console.WriteLine(ID);
        }


    }
}
