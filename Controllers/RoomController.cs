using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using TextAdventure.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Routing;

namespace TextAdventure.Controllers
{
    public class RoomController : Controller
    {
        private readonly IHostingEnvironment _hostEnvironment;
        public RoomController(IHostingEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        [Route("{id?}")]
        public IActionResult Index(int? id)
        {
            id = id ?? 1;
            Room room = loadRoom(id.Value);
            return View(room);
        }

        [Route("/api/Room/{id}")]
        public string Room(int id)
        {
            return System.IO.File.ReadAllText(_hostEnvironment.WebRootPath + $"\\rooms\\{id}.json");
        }

        private Room loadRoom(int id)
        {
            var lines = System.IO.File.ReadAllText(_hostEnvironment.WebRootPath + $"\\rooms\\{id}.json");
            Room room = JsonConvert.DeserializeObject<Room>(lines);
            return room;
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
