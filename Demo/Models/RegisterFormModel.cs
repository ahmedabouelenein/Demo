using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class RegisterFormModel
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public int Age { get; set; }
        public string ReCaptchaToken { get; set; }

    }
}