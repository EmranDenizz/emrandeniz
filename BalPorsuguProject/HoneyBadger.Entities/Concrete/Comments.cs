using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class Comments : EntityBase, IEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Text { get; set; }
        public int ArticleId{ get; set; }
        public Articles Articles{ get; set; }
    }
}
