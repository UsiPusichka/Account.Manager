using Account.Manager.Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Account.Manager.Repository.Entities
{
    [Table("UserProfile")]
    public class UserProfile : BaseEntity
    {
        public UserProfile()
        {
            UserProfileRoles = new HashSet<UserProfileRole>();
            Tokens = new HashSet<Token>();
            Sms = new HashSet<Sms>();
            EmailHashes = new HashSet<EmailHash>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override long Id { get; set; }

        /// <summary>
        /// FK to User entity
        /// </summary>
        public long UserId { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        /// <summary>
        /// phone number
        /// </summary>
        public long Phone { get; set; }

        [MaxLength(256)]
        public string Password { get; set; }

        /// <summary>
        /// Security stamp.
        /// </summary>
        public string SecurityStamp { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool PhoneConfirmed { get; set; }

        /// <summary>
        /// Inform by email
        /// </summary>
        public bool InformByEmail { get; set; }

        /// <summary>
        /// Inform by sms
        /// </summary>
        public bool InformBySms { get; set; }

        [MaxLength(256)]
        public string FirstName { get; set; }

        [MaxLength(256)]
        public string MiddleName { get; set; }

        [MaxLength(256)]
        public string LastName { get; set; }

        public DateTimeOffset? DateBirth { get; set; }

        public DateTimeOffset DateCreated { get; set; }

        public DateTimeOffset? DateUpdated { get; set; }

        public int? GenderId { get; set; }

        public string Language { get; set; }

        public DateTimeOffset? LastSignIn { get; set; }

        public string EmailConfirmCode { get; set; }

        public int EmailSendAttempts { get; set; }

        public int EmailReSendAttempts { get; set; }

        public DateTimeOffset? LastEmailSend { get; set; }

        public DateTimeOffset? LastEmailResend { get; set; }

        public int EmailUnsuccessfulAttempt { get; set; }

        public DateTimeOffset? LastEmailUnsuccessfulAttempt { get; set; }

        public int SmsUnsuccessfulAttempt { get; set; }

        public DateTimeOffset? LastSmsUnsuccessfulAttempt { get; set; }

        #region virtual

        public virtual User User { get; set; }

        public virtual ICollection<Token> Tokens { get; set; }

        public virtual ICollection<EmailHash> EmailHashes { get; set; }

        public virtual ICollection<Sms> Sms { get; set; }

        public virtual ICollection<UserProfileRole> UserProfileRoles { get; set; }


        #endregion
    }
}
