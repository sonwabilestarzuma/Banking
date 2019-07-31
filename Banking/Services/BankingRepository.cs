using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Data;
using Banking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Banking.Services
{
    public class BankingRepository : IBankingRepository
    {
        private BankingDbContext _context;
        private ILogger<BankingRepository> _logger;

        public BankingRepository(BankingDbContext context, ILogger<BankingRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public async Task Add(BankDetail item)
        {
            await _context.Set<BankDetail>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteBankDetailAsync(int id)
        {
            var bankdetail = await GetBankDetailByIdAsync(id);
            if (bankdetail == null)
                return false;
            _context.BankDetails.Remove(bankdetail);
            return (await _context.SaveChangesAsync() > 0);
        }

        public IEnumerable<BankDetail> GetAllBankDetails()
        {
            _logger.LogInformation("Getting All Bank Details from the database");
            return _context.BankDetails.ToList();
        }

        public async Task<BankDetail> GetBankDetailByIdAsync(int id)
        {
            return await _context.BankDetails
                        .Where(v => v.Id == id)
                        .FirstOrDefaultAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
