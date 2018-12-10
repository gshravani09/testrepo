using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class CAP2
    {
        private static string studentname;
        private static int courseno;
        private static DateTime dateTime;
        private static string type2;
        public static string getsn()
        {
            return studentname;
        }

        public static void setsn(String stdname)
        {
            studentname = stdname;
        }

        public static int getcours()
        {
            return courseno;

        }

        public static void setscours(int course)
        {
            courseno = course;

        }

        public static DateTime getstartdate()
        {
            return dateTime;

        }

        public static void setstartdate(DateTime dtTime)
        {
            dateTime = dtTime;
        }

        public static string gettype()
        {
            return type2;

        }

        public static void settype(string Type)
        {
            type2 = Type;
            gettype();
        }
    }
}
