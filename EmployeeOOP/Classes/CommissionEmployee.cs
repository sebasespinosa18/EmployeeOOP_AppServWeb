using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP.Classes
{
    public class CommissionEmployee : Employee
    {
        #region Properties
        public float CommissionPercentaje { get; set; }
        public decimal Sales { get; set; }
        #endregion

        #region Methods
        public CommissionEmployee()
        {
            
        }
        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentaje;
        }
        #endregion

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Comisión:  {CommissionPercentaje:P2}\n\t" +
                $"Ventas:  {Sales:C2}\n\t" +
                $"Valor a pagar:  {GetValueToPay():C2}\n\t";
        }
    }
}
