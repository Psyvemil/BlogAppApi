using BlogApp.BL.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IBlogService _blogService) : ControllerBase
    {
        [HttpGet]   
        public async Task<IActionResult> Get()
        {
            return Ok(await _blogService.GetAllAsync());
        }
    }
}
