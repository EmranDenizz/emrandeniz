using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class Experiences : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string WorkPlace { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}
