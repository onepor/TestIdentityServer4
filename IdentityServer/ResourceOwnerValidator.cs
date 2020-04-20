using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class ResourceOwnerValidator: IResourceOwnerPasswordValidator
    {
        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            if (context.UserName == "Aju" && context.Password == "Aju_password")
            {
                context.Result = new GrantValidationResult(
                    subject: context.UserName,
                    authenticationMethod: OidcConstants.AuthenticationMethods.Password);
            }
            else
            {
                context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, "无效的秘钥");
            }
            return Task.FromResult("");
        }
    }
}
