  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banking.Models;
using Banking.Services;
using Banking.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Banking.Controllers
{
    public class AppController : Controller
    {
        private IBankingRepository _repository;
        private ILogger<BankingRepository> _logger;

        public AppController(IBankingRepository repository, ILogger<BankingRepository> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BankDetails()
        {
            try
            {
                var bankDetails = _repository.GetAllBankDetails();
                return View(bankDetails);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get bank details in database:{ex.Message}");
                return Redirect("/error");
            }
        }
     
    }
}
