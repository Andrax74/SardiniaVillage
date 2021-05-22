using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalutiController : ControllerBase
    {
        public string GetSaluti()
        {
            return "Saluti, sono la tua prima web api creata in C#";
        }
    }
}
