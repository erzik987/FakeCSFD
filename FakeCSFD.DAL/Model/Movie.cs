using FakeCSFD.DAL.Enums;
using FakeCSFD.DAL.Model.Base;
using ImageMagick;
using System;
using System.Collections.Generic;

namespace FakeCSFD.DAL.Model
{
    public class Movie : EntityBase
    {
        public string OriginalName { get; set; }

        public string CzechName { get; set; }

        public Genre Genre { get; set; }

        public MagickImage TitlePhoto { get; set; }

        public string CountryOfOrigin { get; set; }

        public TimeSpan MovieLength { get; set; }

        public string MovieDescription { get; set; }

        public ICollection<Director> Directors { get; set; } 

        public ICollection<Actor> Actors { get; set; } 

        public ICollection<Review> Reviews { get; set; } 
    }
}
