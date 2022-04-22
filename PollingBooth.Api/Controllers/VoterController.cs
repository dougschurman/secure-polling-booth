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
    public class VoterController : ControllerBase
    {
        private readonly IVoterRepository _voterRepo;

        public VoterController(IVoterRepository voterRepo)
        {
            _voterRepo = voterRepo;
        }

        [HttpGet]
        public IActionResult GetVoters()
        {
            var data = _voterRepo.GetVoters();
            return Ok(data);
        }

        [HttpPost]
        public void CreateUser(Voter voter)
        {
            _voterRepo.CreateUser(voter);
        }

        [HttpPost]
        public void setSubmitted(int userId)
        {
            _voterRepo.setSubmitted(userId);
        }
    }
}