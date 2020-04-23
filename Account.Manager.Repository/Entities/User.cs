using Account.Manager.Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    /// <summary>
    /// user entity
    /// </summary>
    [Table("User")]
    public class User : BaseEntity
    {
        public User()
        {
            UserProfiles = new HashSet<UserProfile>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
