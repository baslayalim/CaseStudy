﻿using Microsoft.AspNetCore.Mvc;
using static CaseStudy.Api.Helper.ExceptionHelper;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustumExceptionController : ControllerBase
    {
        [HttpGet]
        public Task<IActionResult> GetCaseStudyException()
        {
            throw new CaseStudyException("CaseStudyException Error");

            return Task.FromResult<IActionResult>(Ok("GetCaseStudyException Success"));
        }

        [HttpGet("AuthenticationException")]
        public Task<IActionResult> GetAuthenticationException()
        {
            throw new AuthenticationException("AuthenticationException Error");

            return Task.FromResult<IActionResult>(Ok("GetAuthenticationException Success"));
        }

        [HttpGet("GetGeneralException")]
        public Task<IActionResult> GetGeneralException()
        {
            throw new Exception("GetGeneralException Error");

            return Task.FromResult<IActionResult>(Ok("GetGeneralException Success"));
        }
    }
}
