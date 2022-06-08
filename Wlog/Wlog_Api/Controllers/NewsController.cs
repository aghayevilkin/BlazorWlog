using Business.Repository.IRepository;
using Microsoft.AspNetCore.Http;
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
    public class NewsController : Controller
    {
        private readonly INewsRepository _newsRepository;
        private readonly INewsCategoryRepository _newsCategoryRepository;
        private readonly INewsSubCategoryRepository _newsSubCategoryRepository;
        private readonly IMessageRepository _messageRepository;


        public NewsController(INewsRepository newsRepository, INewsCategoryRepository newsCategoryRepository, INewsSubCategoryRepository newsSubCategoryRepository, IMessageRepository messageRepository)
        {
            _newsRepository = newsRepository;
            _newsCategoryRepository = newsCategoryRepository;
            _newsSubCategoryRepository = newsSubCategoryRepository;
            _messageRepository = messageRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllNews()
        {

            var model = await _newsRepository.GetAllNews();
            return Ok(model);
        }

        [HttpGet("GetNewsPagingList")]
        public async Task<IActionResult> GetNewsPagingList(int currentPage = 1, int pageSize = 10)
        {

            var result = _newsRepository.GetNewsPagingList(currentPage, pageSize);

            if (result == null)
            {
                return NotFound(result);
            }
            return Ok(result);
        }


        [HttpGet("{newsId}")]
        public async Task<IActionResult> GetNews(int? newsId)
        {
            if (newsId == null)
            {
                return BadRequest(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid News Id",
                    StatusCode = StatusCodes.Status400BadRequest
                });
            }

            var newsDetails = await _newsRepository.GetNews(newsId.Value);

            if (newsDetails == null)
            {
                return NotFound(new ErrorModel()
                {
                    Title = "",
                    ErrorMessage = "Invalid News Id",
                    StatusCode = StatusCodes.Status404NotFound
                });
            }

            return Ok(newsDetails);

        }




        [HttpPost("CreateMessage")]
        public async Task<IActionResult> CreateMessage([FromBody] MessageDTO model)
        {
            if (ModelState.IsValid)
            {
                var result = await _messageRepository. Create(model);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Message"
                });
            }
        }




        [HttpPost("AddToSavedNews")]
        public async Task<IActionResult> AddToSavedNews([FromBody] SavedNewsDTO savedNewsDTO)
        {
            if (ModelState.IsValid)
            {
                var result = await _newsRepository.AddToSavedNews(savedNewsDTO);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Saved News"
                });
            }
        }


    }
}
