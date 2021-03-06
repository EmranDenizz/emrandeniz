using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    public class Articles : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public string Thumnail { get; set; }
        public int ViewsCount { get; set; } = 0;
        public string SeoTags { get; set; }
        public string SeoDescription { get; set; }
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}
