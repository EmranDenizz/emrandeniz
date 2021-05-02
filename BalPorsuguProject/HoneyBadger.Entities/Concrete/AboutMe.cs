using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class AboutMe : EntityBase, IEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }
        public string MyJob { get; set; }
        public string MyJobFA { get; set; }
        public DateTime BirthDate { get; set; }
        public string MyCvPath { get; set; }
    }
}
