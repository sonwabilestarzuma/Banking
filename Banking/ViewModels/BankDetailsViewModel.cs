using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.ViewModels
{
    public class BankDetailsViewModel
    {
        public BankDetail BankDetail { get; set; }
        public List<BankDetail> BankDetails { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int TransactionCode { get; set; }
        public double TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime TransactionTime { get; set; }
        public string DrCrIndicator { get; set; }
        public string StandardBank { get; set; }
        public int BranchCode { get; set; }
        public string ReferenceNumber { get; set; }
        public long AccountNumber { get; set; }
        public string Identifier { get; set; }

    }
}
