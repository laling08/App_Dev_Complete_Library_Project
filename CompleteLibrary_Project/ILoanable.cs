using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteLibrary_Project
{
    /// <summary>
    /// Interface for loanable media items.
    /// </summary>
    public interface ILoanable
    {
        void Checkout();
        void ReturnItem();
        void RenewLoan();
        void GiveLateFee();
    }
}
