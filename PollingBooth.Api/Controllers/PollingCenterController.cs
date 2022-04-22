using Microsoft.AspNetCore.Mvc;
using PollingBooth.Api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq;
using PollingBooth.Api.Models;

namespace PollingBooth.Api.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class PollingCenterController : ControllerBase
    {
        private readonly IPollingCenterRepository _centerRepo;

        public PollingCenterController(IPollingCenterRepository centerRepo)
        {
            _centerRepo = centerRepo;
        }

        [HttpGet]
        public IActionResult GenerateBallots(){
            var data = _centerRepo.GenerateBallots();
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetSubmitted()
        {
            var data = _centerRepo.GetSubmitted();
            return Ok(data);
        }
    }
}