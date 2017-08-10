using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnakeEyesGame.Models;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SnakeEyesGame.Controllers
{
    public class HomeController : Controller {

	    private SnakeEyes _snakeEyes;
        // GET: /<controller>/
        public IActionResult Index()
        {
			_snakeEyes = new SnakeEyes();
	        SetSession();
            return View(_snakeEyes);
        }

	    public IActionResult Play() {
		    _snakeEyes = JsonConvert.DeserializeObject<SnakeEyes>(HttpContext.Session.GetString("SnakeEyes"));
		    _snakeEyes.Play();
		    SetSession();
			return View("Index",_snakeEyes);
	    }

	    public void SetSession() {
		    HttpContext.Session.SetString("SnakeEyes", JsonConvert.SerializeObject(_snakeEyes));
	    }
    }
}
