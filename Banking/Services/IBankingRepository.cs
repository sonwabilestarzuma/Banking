using Banking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.Services
{
    public interface IBankingRepository
    {

        IEnumerable<BankDetail> GetAllBankDetails();
       // Task<bool> UpdateBankDetailAsync(BankDetail bankDetail);
        Task<BankDetail> GetBankDetailByIdAsync(int id);
        Task<bool> DeleteBankDetailAsync(int id);
        Task<bool> SaveChangesAsync();
        //Task Update(BankDetail bankDetail);
        Task Add(BankDetail bankDetail);
        

    }
}
