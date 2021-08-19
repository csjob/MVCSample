using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCSample.Models
{
    public class About
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
    }

    public class Hello
    {
        public int Id { get; set; }
        public string HelloName { get; set; }
    }
}