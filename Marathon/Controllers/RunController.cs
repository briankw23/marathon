﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marathon.DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Marathon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunController : ControllerBase
    {
        private readonly RunStorage _storage;

        public RunController(IConfiguration config)
        {
            _storage = new RunStorage(config);
        }

        // GET ALL RUNS
        [HttpGet]
        public IActionResult GetTheOnlyUser()
        {
            return Ok(_storage.GetAllRunTasks());
        }
    }
}