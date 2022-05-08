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
    public class NewsCommentController : Controller
    {
        private readonly INewsCommentRepository _newsCommentRepository;

        public NewsCommentController(INewsCommentRepository newsCommentRepository)
        {
            _newsCommentRepository = newsCommentRepository;
        }



        [HttpGet]
        public async Task<IActionResult> GetAllComment()
        {

            var model = await _newsCommentRepository.GetAllNewsComment();
            return Ok(model);
        }



        [HttpPost]
        public async Task<IActionResult> CreateNewsComment([FromBody] NewsCommentDTO newsCommentDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _newsCommentRepository.CreateNewsComment(newsCommentDTO);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Comment"
                });
            }
        }
    }
}
