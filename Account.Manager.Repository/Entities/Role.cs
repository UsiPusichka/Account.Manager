using Account.Manager.Repository.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("Role")]
    public class Role : BaseEntity
    {
        public Role()
        {
            UserProfileRoles = new HashSet<UserProfileRole>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override long Id { get; set; }

        [MaxLength(512)]
        public string Name { get; set; }

        #region virtual

        public virtual ICollection<UserProfileRole> UserProfileRoles { get; set; }

        #endregion
    }
}
