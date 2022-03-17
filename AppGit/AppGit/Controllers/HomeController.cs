using AppGit.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Threading.Tasks;
using AppGit.Services;

namespace AppGit.Controllers
{
    public class HomeController : Controller
    {
        private readonly GitService service = new GitService();
        private readonly IConfiguration _configuration;
        //private RepoContext context;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        
        public IActionResult Index()
        {
            var model = new Languages();
            return View(model);
        }

        [HttpPost]
        public IActionResult List(Languages languages)
        {
            var task = service.GetRepos(languages.language.ToString());
            task.Wait(); // Blocks current thread until GetFooAsync task completes
                         // For pedagogical use only: in general, don't do this!
            var result = task.Result;
            return View(result);

        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}
