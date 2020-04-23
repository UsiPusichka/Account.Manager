using System;
using System.Collections.Generic;
using System.Text;

namespace Account.Manager.Repository.Entities.Base
{
    public abstract class BaseEntity
    {
        public abstract long Id { get; set; }
    }
}
