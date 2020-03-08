using FakeCSFD.DAL.Model.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeCSFD.DAL.Model
{
    public class Review : EntityBase
    {
        public float Rating { get; set; }

        public string Comment { get; set; }

        public Movie Movie { get; set; }
    }
}
