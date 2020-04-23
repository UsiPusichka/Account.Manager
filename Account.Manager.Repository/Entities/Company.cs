using Account.Manager.Repository.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("Company")]
    public class Company : BaseEntity
    {
        public Company()
        {
            UserProfileRoles = new HashSet<UserProfileRole>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        [MaxLength(512)]
        public string Name { get; set; }

        public virtual ICollection<UserProfileRole> UserProfileRoles { get; set; }
    }
}
