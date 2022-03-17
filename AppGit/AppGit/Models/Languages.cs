
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AppGit.Models
{
    public class Languages
    {
        public string language { get; set; }

        public List<SelectListItem> languages = new List<SelectListItem>
        {
            new SelectListItem{ Value = "Asp", Text = "Asp"},
            new SelectListItem{ Value = "C#", Text = "C#"},
            new SelectListItem{ Value = "Ruby", Text = "Ruby"},
            new SelectListItem{ Value = "PHP", Text = "PHP"},
            new SelectListItem{ Value = "Elixir", Text = "Elixir"},
            new SelectListItem{ Value = "Java", Text = "Java"},
            new SelectListItem{ Value = "Python", Text = "Python"}
        };
    }
}
