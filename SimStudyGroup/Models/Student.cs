using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace SimStudyGroup.Models
{
	public class Student
	{
        [DisplayName ("STUDENT NUMBER")]
		public string StudentNo { get; set; }


        [DisplayName("NAME")]
        public string Name { get; set; }


        [DisplayName("SURNAME")]
        public string Surname { get; set; }


        [DisplayName("EMAIL")]
        public string Email { get; set; }


    }
}