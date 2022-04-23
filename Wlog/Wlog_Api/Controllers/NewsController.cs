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


        public NewsController(INewsRepository newsRepository, INewsCategoryRepository newsCategoryRepository, INewsSubCategoryRepository newsSubCategoryRepository)
        {
            _newsRepository = newsRepository;
            _newsCategoryRepository = newsCategoryRepository;
            _newsSubCategoryRepository = newsSubCategoryRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllNews()
        {

            var model = await _newsRepository.GetAllNews();
            return Ok(model);
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








        [HttpGet("NewsCategory")]
        public async Task<IActionResult> GetAllCategory()
        {

            var model = await _newsCategoryRepository.GetAllNewsCategory();
            return Ok(model);
        }


        [HttpGet("NewsSubCategory")]
        public async Task<IActionResult> GetAllSubCategory()
        {

            var model = await _newsSubCategoryRepository.GetAllNewsSubCategory();
            return Ok(model);
        }



    }
}
