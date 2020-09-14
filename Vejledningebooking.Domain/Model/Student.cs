using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vejledningebooking.Domain.Model
{
    class Student
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

    }
}
