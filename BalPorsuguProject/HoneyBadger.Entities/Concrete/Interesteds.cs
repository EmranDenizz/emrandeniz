using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class Interesteds : EntityBase, IEntity
    {
        public string Text { get; set; }
    }
}
