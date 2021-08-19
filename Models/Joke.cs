using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorialAsp.Models
{
    public class Joke
    {
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public String Questions { get; set; }

        [BindProperty(SupportsGet = true)]
        public String Answer { get; set; }

        public Joke()
        {

        }
    }
}
