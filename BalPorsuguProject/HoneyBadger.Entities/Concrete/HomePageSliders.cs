using HoneyBadger.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Entities.Concrete
{
    // IEntity interface ile bu sınıfın bir db tablosu tutacağını bildirmiş olduk.
    public class HomePageSliders : EntityBase, IEntity // Ortak özellikleri almak içib shared katmanını referans almalıyız entities katmanı içinde.
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
    }
}
