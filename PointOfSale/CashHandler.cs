using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    public class CashHandler
    {

        public int hundredsCount
        {
            get
            {
                return CashDrawer.Hundreds;
            }

            set
            {
                CashDrawer.Hundreds = value;
            }
        }
        public int fiftyCount
        {
            get
            {
                return CashDrawer.Fifties;
            }

            set
            {
                CashDrawer.Fifties = value;
            }
        }

        public int twentyCount
        {
            get
            {
                return CashDrawer.Twenties;
            }

            set
            {
                CashDrawer.Twenties = value;
            }
        }

        public int tenCount
        {
            get
            {
                return CashDrawer.Tens;
            }

            set
            {
                CashDrawer.Tens = value;
            }
        }

        public int fiveCount
        {
            get
            {
                return CashDrawer.Fives;
            }

            set
            {
                CashDrawer.Fives = value;
            }
        }

        public int twoCount
        {
            get
            {
                return CashDrawer.Twos;
            }

            set
            {
                CashDrawer.Twos = value;
            }
        }

        public int oneCount
        {
            get
            {
                return CashDrawer.Ones;
            }

            set
            {
                CashDrawer.Ones = value;
            }
        }

        public int dollarCount
        {
            get
            {
                return CashDrawer.Dollars;
            }

            set
            {
                CashDrawer.Dollars = value;
            }
        }

        public int halfDollarCount
        {
            get
            {
                return CashDrawer.HalfDollars;
            }

            set
            {
                CashDrawer.HalfDollars = value;
            }
        }

        public int quarterCount
        {
            get
            {
                return CashDrawer.Quarters;
            }

            set
            {
                CashDrawer.Quarters = value;
            }
        }

        public int dimeCount
        {
            get
            {
                return CashDrawer.Dimes;
            }

            set
            {
                CashDrawer.Dimes = value;
            }
        }

        public int nickleCount
        {
            get
            {
                return CashDrawer.Nickels; //oops
            }

            set
            {
                CashDrawer.Nickels = value;
            }
        }

        public int pennyCount
        {
            get
            {
                return CashDrawer.Pennies;
            }

            set
            {
                CashDrawer.Pennies = value;
            }
        }

        public CashHandler()
        {
        }
    }
}
