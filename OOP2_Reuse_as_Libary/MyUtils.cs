using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Reuse_as_Libary
{
    public static class MyUtils
    {
        //cài đặt 1 hàm để tính tuổi cho employee 
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year + 1;
        }
    }
}
