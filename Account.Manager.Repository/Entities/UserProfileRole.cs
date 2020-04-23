using Account.Manager.Repository.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("UserProfileRole")]
    public class UserProfileRole : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        public long UserProfileId { get; set; }

        public long RoleId { get; set; }

        public long CompanyId { get; set; }

        [ForeignKey("UserProfileId")]
        public virtual UserProfile UserProfile { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}
