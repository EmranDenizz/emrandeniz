using HoneyBadger.Shared.Entities.Abstract;

namespace HoneyBadger.Entities.Concrete
{
    public class Messages : EntityBase, IEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
