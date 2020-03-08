using System;
using System.Collections.Generic;
using System.Text;

namespace FakeCSFD.DAL.Model.Base
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}
