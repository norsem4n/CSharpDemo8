/* Project:         Assignment Set 3; Program 8
 * Date Created:    September 2020
 * Last Modified:   10.8.2020
 * Developed By:    CGK
 * Class Name:      PaySlip
 * Description:     Creates a PaySlip and a cumulative record
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram8._2
{
    class PaySlip
    {
        #region "Variables/ Instance Fields"

        // 4 instance variable properties (read only fields)

        public readonly string CustomerName;
        public readonly decimal HoursWorked;
        public readonly decimal PayRate;
        public readonly decimal NetPayCheck;

        #endregion

        #region "Properties"

        // 3 static auto implemented properties 

        public static int TotalPaySlips { get; private set; }
        public static decimal TotalGrossPay { get; private set; }
        public static decimal TotalNetPay { get; private set; }

        #endregion

        #region "Constructors"

        // constructor that instantiates an object and sets three properties
        public PaySlip (string strName, decimal hoursWorked, decimal payRate)
        {
            CustomerName = strName;
            HoursWorked = hoursWorked;
            PayRate = payRate;
            
            //TotalNetPay = netPay;

            NetPayCheck = CalculateNetPay();
        }

        #endregion

        #region "Methods"

        //private instance method that calculates net pay

        private decimal CalculateNetPay()
        {
            //constants and variables

            const decimal fedTax = 0.1075M;
            const decimal stateTax = 0.0463M;
            const decimal socSecTax = 0.062M;
            const decimal medTax = 0.0145M;

            decimal netPay, grossPay;

            // calculate net pay
            // Net pay = Gross Pay – Federal Income Tax – State Income Tax - Social Security Tax – Medicare Tax

            grossPay = HoursWorked * PayRate;
            netPay = grossPay - (grossPay * fedTax) - (grossPay * stateTax) - (grossPay * socSecTax) - (grossPay * medTax);

            // increment static properties

            TotalPaySlips++;

            TotalGrossPay += grossPay;
            TotalNetPay += netPay;

            // return net pay

            return netPay;
        }

        //public static method that calculates average net pay

        public static decimal CalculateAvgNetPay()
        {
            // variable

            decimal result = 0;

            // calculate average net pay

            if (TotalNetPay > 0)
            {
                result = (decimal) TotalNetPay / TotalPaySlips;
            }
            return result;
        }

        #endregion
    }
}
