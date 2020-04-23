using Account.Manager.Repository.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("Token")]
    public class Token : BaseEntity
    {
        public Token()
        {

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        public long UserProfileId { get; set; }

        [Required]
        public string AccessToken { get; set; }

        [Required]
        public string RefreshToken { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset DateAccessTokenExpires { get; set; }

        public DateTimeOffset DateRefreshTokenExpires { get; set; }

        public virtual UserProfile UserProfile { get; set; }

    }
}
