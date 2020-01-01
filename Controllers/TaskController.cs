using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CouchSignal.Data;

namespace CouchSignal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly DataContext _context;

        public TaskController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Dictionary<string, string> GetIndex()
        {
            return new Dictionary<string, string>()
                {
                    {"message", "test 123"}
                };
        }

        [HttpPost]
        public string PostTask()
        {
            return "test";
        }
    }
}