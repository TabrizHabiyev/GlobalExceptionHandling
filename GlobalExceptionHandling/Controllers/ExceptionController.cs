using GlobalEx = GlobalExceptionHandling.ExceptionModels;
using Microsoft.AspNetCore.Mvc;
using GlobalExceptionHandling.Filters;

namespace GlobalExceptionHandling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ExceptionHandling]
    public class HomeController : ControllerBase
    {
    
        [HttpGet("notfound")]
        public async Task<IActionResult> GetNotFoundException()
        {
            throw new GlobalEx.NotFoundException("This is my not found exception design");
        }

        [HttpGet("unauthorized")]
        public async Task<IActionResult> GetUnauthorizedException()
        {
            throw new GlobalEx.UnauthorizedException("This is my unauthorized exception design");
        }

        [HttpGet("forbidden")]
        public async Task<IActionResult> GetForbiddenException()
        {
            throw new GlobalEx.ForbiddenException("This is my forbidden exception design");
        }

        [HttpGet("badrequest")]
        public async Task<IActionResult> GetBadRequestException()
        {
            throw new GlobalEx.BadRequestException("This is my bad request exception design");
        }

        [HttpGet("conflict")]
        public async Task<IActionResult> GetConflictException()
        {
            throw new GlobalEx.ConflictException("This is my conflict exception design");
        }

        [HttpGet("notimplemented")]
        public async Task<IActionResult> GetNotImplementedException()
        {
            throw new GlobalEx.NotImplementedException("This is my not implemented exception design");
        }
        
    }
}