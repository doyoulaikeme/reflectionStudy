﻿using DBInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlDB
{

    public class MysqlHelper : IDBHelper
    {
        public MysqlHelper()
        {

            Console.WriteLine("{0}被构造", this.GetType().Name);
        }


        public void Query()
        {
            Console.WriteLine("{0}  Query执行", this.GetType().Name);
        }
    }
}
