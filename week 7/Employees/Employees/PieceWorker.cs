using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employees
{
    public class PieceWorker : Employee
    {
        private int quantity;
        private decimal wageperPiece;

        public PieceWorker(string firstNameValue, string lastNameValue, decimal wageperPieceValue, int quantityValue) :base(firstNameValue, lastNameValue)
        {
            WagePerPiece = wageperPieceValue;
            Quantity = quantityValue;
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public decimal WagePerPiece
        {
            get
            {
                return wageperPiece;
            }
            set
            {
                if (value > 0)
                    wageperPiece = value;
            }
        }

        public override decimal Earnings()
        {
            return Quantity * WagePerPiece;
        }

        public override string ToString()
        {
            return "PieceWorker: " + base.ToString();
        }
    }
}