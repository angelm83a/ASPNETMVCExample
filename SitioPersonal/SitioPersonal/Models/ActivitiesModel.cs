using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SitioPersonal.Models
{
    public class ActivitiesModel
    {
        /*Resume*/
        public string ResumeName
        {
            get;
            set;
        }

        /*Message form*/
        //[Required, Display(Name = "Name Lastname")] //placeholders
        public string FromName { get; set; }

        //[Required, Display(Name = "yourEmail@yahoo.com"), EmailAddress] //placeholders
        public string FromEmail { get; set; }

        [Required]
        public string FromMessage { get; set; }

        public string SetMessageOnScreenHeader
        {
            get;
            set;
        }

        public string SetMessageOnScreenTextBlock
        {
            get;
            set;
        }
    }
}