using FakeCSFD.DAL.Enums;
using ImageMagick;
using System.Collections.Generic;

namespace FakeCSFD.DAL.Model.Base
{
    public class Person : EntityBase
    {
        public PersonType Type { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public MagickImage Photo { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
