using System;
using System.Collections.Generic;
using System.Text;

namespace HoneyBadger.Shared.Entities.Abstract
{
    public abstract class EntityBase //abstract kelimesi base sınıflarda tanımlanır genellikle. DEğişmez özellikler tanımlarken kullanılabilir.
    {
        //abstrac tanımlanan sınıflarda virtual anahtar kelimesi kullanışır ki sanal oldupu soyut olduğu belli olsun.
        // Alt Gr basılı tutup aşağı indikçe yazdığın anahtar kelime tüm property'lere yazılmış olur.
        public virtual  int Id { get; set; }
        public virtual DateTime CreatedTime { get; set; } = DateTime.Now; //Oluşturulduğu zamanı alır.
        public virtual DateTime UpdatedTime { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = false; // Başlangıçta false olur.
        public virtual bool IsDelete { get; set; } = false; // Oluşturulmuş bir şey silinmemiştir. Yani false.
        public virtual string CreatedByName { get; set; } = "ed";
        public virtual string UpdatedByName { get; set; } = "ed";
    }
}
