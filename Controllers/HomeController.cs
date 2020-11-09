using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vetapi.DAL;
using vetapi.Models;

namespace vetapi.Controllers
{
    [Route("/")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index() => Ok("VetApi");
    }
}
