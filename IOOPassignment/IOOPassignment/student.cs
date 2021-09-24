using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPassignment
{
    class student
    {
        private string accountid;
        private string password;
        private string studentname;
        private string contact;
        private string date;
        private double balance;
        private string homeaddress;
        private string emailaddress;

        public string stuid
        {
            get
            {
                return accountid;
            }
            set
            {
                accountid = value;
            }
        }

        public string stups
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string stuname
        {
            get
            {
                return studentname;
            }
            set
            {
                studentname = value;
            }
        }
        public string stucnt
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }
        public string studt
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public double stdbln
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }

        public string ha
        {
            get
            {
                return homeaddress;
            }
            set
            {
                homeaddress = value;
            }
        }
        public string ea
        {
            get
            {
                return emailaddress;
            }
            set
            {
                emailaddress = value;
            }
        }

        public student (string id, string ps)
        {
            accountid = id;
            password = ps;
        }

        public student (string nm, string cnt, string dt, double bln)
        {
            studentname = nm;
            contact = cnt;
            date = dt;
            balance = bln;
        }

        public student(string p, string ha, string ea, string cn, string n)
        {
            password = p;
            contact = cn;
            studentname = n;
            homeaddress = ha;
            emailaddress = ea;
        }
    }
}
