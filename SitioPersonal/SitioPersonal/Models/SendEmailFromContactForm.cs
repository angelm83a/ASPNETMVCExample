using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SitioPersonal.Models
{
    public class SendEmailFromContactForm
    {
        //public class EmailFormModel
        //{
        //    [Required, Display(Name = "Angelo Munoz")]
        //    public string FromName { get; set; }
        //    [Required, Display(Name = "angelm83a@yahoo.com"), EmailAddress]
        //    public string FromEmail { get; set; }
        //    [Required]
        //    public string Message { get; set; }
        //}
        [Required, Display(Name = "Angelo Munoz")]
        public string FromName { get; set; }

        [Required, Display(Name = "angelm83a@yahoo.com"), EmailAddress]
        public string FromEmail { get; set; }

        [Required]
        public string Message { get; set; }

        public string ContactName
        {
            get;
            set;
        }
        public string ContactEmailAddress
        {
            get;
            set;
        }
        public string ContactMessage
        {
            get;
            set;
        }
    }
}