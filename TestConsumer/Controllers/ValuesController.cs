﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FluentHttp;
using Microsoft.AspNetCore.Mvc;

namespace TestConsumer.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IFluentHttpClientFactory _factory;

        public ValuesController(IFluentHttpClientFactory factory)
        {
            _factory = factory;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            var client = _factory.CreateUsingConnectionString("JsonPlaceholder");
            var posts = await client
                .GetAsync("posts", cancellationToken)
                .AsMany(new
                {
                    UserId = 0,
                    Id = 0,
                    Title = string.Empty,
                    Body = string.Empty
                });

            return Ok();
        }
    }
}
