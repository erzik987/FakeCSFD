using FakeCSFD.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FakeCSFD.DAL.Model.Base
{
    public class Person
    {
        public PersonType Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Image Photo { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
