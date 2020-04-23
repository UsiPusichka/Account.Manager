using Account.Manager.Repository.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("EmailHash")]
    public class EmailHash : BaseEntity
    {
        [Key]
        public override long Id { get; set; }

        public long UserProfileId { get; set; }

        public string Hash { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
