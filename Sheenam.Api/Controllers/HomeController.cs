﻿/*
Copyright (c) is allowed for only
education reasons. Author : DimaDev.
*/
using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => 
            Ok("Hello, World!. This is me dilmurod");

    }
}

