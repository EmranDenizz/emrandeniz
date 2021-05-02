using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class ContactInformation : EntityBase, IEntity
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ShortAddress { get; set; }
        public string Address { get; set; }
    }
}
