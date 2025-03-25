using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P316
{
    public class Bank
    {
        private double _currBalance;
        private static double _bonus;
        public Bank(double balance)
        {
            _currBalance = balance;
        }
        static Bank()
        {
            _bonus = 1.04;
        }
        public static void setBonus(double newRate)
        {
            _bonus = newRate;
        }
        public static double getBonus()
        {
            return _bonus;
        }
        public double GetPercents(double summa)
        {
            if ((_currBalance - summa) > 0)
            {
                double percent = summa * _bonus;
                _currBalance-= percent;
                return percent;
            }
            return -1;
        }
                
    }       
    
}
