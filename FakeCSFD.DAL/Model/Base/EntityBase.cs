using System;
using System.Collections.Generic;
using System.Text;

namespace FakeCSFD.DAL.Model.Base
{
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; set; }
    }
}
