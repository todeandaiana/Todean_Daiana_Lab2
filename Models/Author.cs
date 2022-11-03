﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Todean_Daiana_Lab2.Models
{

        public class Author
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            [Display(Name = "FullName")]
            public string FullName
            {
                get
                {
                    return FirstName + " " + LastName;
                }
            }
            public ICollection<Book>? Books { get; set; } //navigation property
        }
   
}
