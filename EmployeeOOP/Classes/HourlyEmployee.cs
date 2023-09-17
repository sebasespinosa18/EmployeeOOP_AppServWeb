using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class HourlyEmployee : Employee
    {
        #region Properties
        public float Hours { get; set; }

        public decimal HoursValue { get; set; }
        #endregion

        #region Methods
        public HourlyEmployee()
        {
            
        }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HoursValue;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Comisión:  {Hours:P2}\n\t" +
                $"Ventas:  {HoursValue:C2}\n\t" +
                $"Valor a pagar:  {GetValueToPay():C2}\n\t";
        }
        #endregion
    }
}
