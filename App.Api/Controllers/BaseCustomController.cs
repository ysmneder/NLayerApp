using System;
using Microsoft.AspNetCore.Mvc;
using App.Core.Dtos;

namespace App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCustomController:ControllerBase
	{

        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            return new ObjectResult(response)
            {
                StatusCode = Response.StatusCode,
            };

        }
	}
}

