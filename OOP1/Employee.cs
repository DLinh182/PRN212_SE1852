using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    #region Nhóm các thuộc tính của Employee 
    public class Employee
    {
        private int _id;                //instance va  
        private String _name;
        private String _email;
        private String _phone;
        #endregion


        #region Nhóm các constructor của Employee 

        public Employee() 
        { 

        }

        public Employee(int _id, string _name, string _email, string _phone)  //local va..
        {
            this._id = _id;
            this._name = _name ;

            //hoặc 
            Email = _email;    //là gọi setter cho property email 
            Phone = _phone;
        }
        #endregion

        #region Nhóm các property của Employee 
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Name
        {
            get { return _name; }       
            set { _name = value; }
        }

        public String Email
        {
            get { return _email; }  
            set { _email = value; }
        }

        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public void PrintInfor()
        {
            Console.WriteLine($"{_id}\t{_name}\t{_email}\t{_phone}");
        }

        public override string ToString()
        {
            String msg = $"{_id}\t{_name}\t{_email}\t{_phone}";
            return msg;
        }
        #endregion
    }
}
