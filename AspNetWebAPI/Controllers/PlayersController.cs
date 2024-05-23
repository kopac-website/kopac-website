using AspNetCoreAPI.Data;
using AspNetCoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace AspNetCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PlayersController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable Players()
        {
            IEnumerable<PlayersModel> players = _context.Players;

            return players;
        }
    }
}
