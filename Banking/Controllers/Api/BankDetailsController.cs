using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Banking.Services;
using Banking.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Banking.Controllers.Api
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BankDetailsController : ControllerBase
    {
        private IBankingRepository _repository;
        private ILogger<BankDetailsController> _logger;

        public BankDetailsController(IBankingRepository repository, ILogger<BankDetailsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                var results = _repository.GetAllBankDetails();

                return Ok(Mapper.Map<IEnumerable<BankDetailsViewModel>>(results));
            }
            catch (Exception ex)
            {
                //TODO logging
                _logger.LogError($"Failed to get all Bank Details:{ex}");

                return BadRequest("Error // Occured");
            }
        }


    }
}