using Account.Manager.Repository.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("Sms")]
    public class Sms : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        public string Code { get; set; }

        public long UserProfileId { get; set; }

        public long CompanyId { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset DateExpired { get; set; }

        public DateTimeOffset? DateActivated { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
