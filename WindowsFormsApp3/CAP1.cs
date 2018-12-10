using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class CAP1
    {
        private static string txtstdname1;
        private static int nocourse;
        private static DateTime datTime;
        private static string type;



        public static void getsn()
        {
            CAP2.setsn(txtstdname1);

        }

        public static void setsn(String sname)
        {
            txtstdname1 = sname;
            getsn();
        }

        public static void getnocours()
        {
            CAP2.setscours(nocourse);

        }

        public static void setscours(int course)
        {
            nocourse = course;
            getnocours();
        }

        public static void getdate()
        {
            CAP2.setstartdate(datTime);

        }

        public static void setstdate(DateTime dtTime)
        {
            datTime = dtTime;
            getdate();
        }

        public static void gettype()
        {
            CAP2.settype(type);

        }

        public static void settype(string Type)
        {
            type = Type;
            gettype();
        }
    }
}
