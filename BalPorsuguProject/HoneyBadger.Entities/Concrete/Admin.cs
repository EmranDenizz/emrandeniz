using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class Admin : EntityBase,IEntity
    {
        public string Email { get; set; }
        public string Pasword { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityQAnswer { get; set; }
    }
}
