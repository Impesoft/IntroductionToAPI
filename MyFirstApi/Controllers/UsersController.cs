﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstApi.MakingAPoint;
using MyFirstApi.Services;

namespace MyFirstApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController: ControllerBase
    {
        private IAppUserService _service;
        private ILogger<UsersController> _logger;
        private IMainClass _mainClass;

        public UsersController(IAppUserService service, IMainClass mainClass)
        {
            // Dependency Injection
            _service = service;
            _mainClass = mainClass;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetAsync()
        {
            return  await _service.GetUsers();
        }

        [HttpGet("{id}")]
        public async Task<AppUser> GetUserAsync(int id)
        {
            return await _service.GetUser(id);
        }

        [HttpPost]
        public async Task AddUserAsync(AppUser user)
        {
            await _service.AddUser(user);
        }
    }
}