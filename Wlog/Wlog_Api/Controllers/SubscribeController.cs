using Business.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wlog_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubscribeController : Controller
    {
        private readonly ISubscribeRepository _subscribeRepository;

        public SubscribeController(ISubscribeRepository subscribeRepository)
        {
            _subscribeRepository = subscribeRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllSubscribe()
        {

            var model = await _subscribeRepository.GetAllSubscribe();
            return Ok(model);
        }



        [HttpPost]
        public async Task<IActionResult> CreateSubscribe([FromBody] SubscribeDTO subscribeDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _subscribeRepository.CreateSubscribe(subscribeDTO);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Subscribe"
                });
            }
        }
    }
}
