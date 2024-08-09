using BlogApp.BL.Dtos.BlogDtos;
using BlogApp.BL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
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
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _blogService.GetByIdAsync(id));
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]BlogCreateDto dto)
        {
            try 
            {
               await _blogService.CreateAsync(dto);
                return Ok();
            }
            catch (Exception ex) {return BadRequest(ex.Message); }
        }
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _blogService.RemoveAsync(id);
            return Accepted();
        }
    }
}
