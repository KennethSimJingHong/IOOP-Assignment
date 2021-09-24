using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPassignment
{
    class Tutor
    {
        private string accountid;
        private string password;
        private string tutorname;
        private string contact;
        private double charges;
        private string emailaddress;
        private string date;
        private string subject;

        public string tutid
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

        public string tutps
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

        public string tutname
        {
            get
            {
                return tutorname;
            }
            set
            {
                tutorname = value;
            }
        }

        public string tutcnt
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

        public string tutea
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

        public double tutcharges
        {
            get
            {
                return charges;
            }
            set
            {
                charges = value;
            }
        }

        public string tutdate
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

        public string tutsubject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public Tutor(string id, string p, string ea, string cn, string n, string d, double c)
        {
            accountid = id;
            password = p;
            contact = cn;
            tutorname = n;
            emailaddress = ea;
            d = date;
            c = charges;
        }
    }
}
