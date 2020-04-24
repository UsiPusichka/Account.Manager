using Account.Manager.Repository.Abstract;
using Account.Manager.Repository.Entities;
using Account.Manager.SDK.Models.Auth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Account.Manager.Service.Concrete.Base
{
    public abstract class BaseAuthService
    {
        protected readonly ITokenRepository _tokenRepository;

        public BaseAuthService(ITokenRepository tokenRepository) =>
            _tokenRepository = tokenRepository;

        /// <summary>
        /// Generate, save and return token to user profile
        /// </summary>
        /// <param name="userProfile">user profile</param>
        /// <param name="userRoles">list of user roles</param>
        /// <param name="maxActiveTokens">max active tokens count at the moment</param>
        /// <returns>Auth token data model</returns>
        protected Task<AuthTokenDataModel> IssueToken(UserProfile userProfile, List<UserProfileRole> userRoles, int maxActiveTokens = 2)
        {
            throw new NotImplementedException();
        }

        protected ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
