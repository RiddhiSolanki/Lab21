using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab21.Models
{
    public class Response
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Email     { get; set; }
        public string Phone     { get; set; }
        public String Address   { get; set; }
        public bool? Gender    { get; set; }
        public bool? Agree      { get; set; }                  //? allow null
    }
}