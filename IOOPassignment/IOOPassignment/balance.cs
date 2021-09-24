using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOPassignment
{
    class balance
    {
        private double totalbalance;
        private double reload;
        private double deduct;

        public double stutb
        {
            get
            {
                return totalbalance;
            }
            set
            {
                totalbalance = value;
            }
        }

        public double sturld
        {
            get
            {
                return reload;
            }
            set
            {
                reload = value;
            }
        }

        public double studuct
        {
            get
            {
                return deduct;
            }
            set
            {
                deduct = value;
            }
        }

        public balance (double ttlbln)
        {
            totalbalance = ttlbln;
        }

        public double BalanceReload(double ttlbln, double blnrld)
        {
            return ttlbln + blnrld;
        }

        public double BalanceDeduct(double ttlbln, double blnddt)
        {
            return ttlbln - blnddt;
        }
    }
}
