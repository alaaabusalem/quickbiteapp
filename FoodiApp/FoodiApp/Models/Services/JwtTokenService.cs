using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FoodiApp.Models.Services
{
	public class JwtTokenService
	{
		private IConfiguration configuration;
		private SignInManager<ApplicationUser> signInManager;

		public JwtTokenService(IConfiguration config, SignInManager<ApplicationUser> manager)
		{
			configuration = config;
			signInManager = manager;
		}
		public static TokenValidationParameters GetValidationPerameters(IConfiguration configuration)
		{
			return new TokenValidationParameters
			{
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = GetSecurityKey(configuration),
				ValidateIssuer = false,
				ValidateAudience = false
			};
		}

		private static SecurityKey GetSecurityKey(IConfiguration configuration)
		{
			var secret = configuration["JWT:Secret"];
			if (secret == null)
			{
				throw new InvalidOperationException("JWT: Secret key is not exist");
			}

			var secretBytes = Encoding.UTF8.GetBytes(secret);

			return new SymmetricSecurityKey(secretBytes);
		}

		public async Task<string> GetToken(ApplicationUser user, TimeSpan expiresIn)
		{
			var principle = await signInManager.CreateUserPrincipalAsync(user);

			if (principle == null)
			{
				return null;
			}
			var signingKey = GetSecurityKey(configuration);

			var token = new JwtSecurityToken(
				expires: DateTime.UtcNow + expiresIn,
				signingCredentials: new SigningCredentials(signingKey,
				SecurityAlgorithms.HmacSha256),
				claims: principle.Claims

				);

			return new JwtSecurityTokenHandler().WriteToken(token);


		}

		//public async Task<ClaimsPrincipal> GetUserFromToken(string token)
		//{
		//	var tokenHandler = new JwtSecurityTokenHandler();
		//	var tokenValidationParameters = new TokenValidationParameters
		//	{
		//		ValidateIssuerSigningKey = true,
		//		IssuerSigningKey = GetSecurityKey(configuration), // Replace with your signing key
		//		ValidateIssuer = false, // Set to true if issuer validation is required
		//		ValidateAudience = false // Set to true if audience validation is required
		//	};

		//	try
		//	{
		//		ClaimsPrincipal principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out SecurityToken validatedToken);
		//		return principal;
		//	}
		//	catch (Exception ex)
		//	{
		//		// Token validation failed
		//		return null;
		//	}
		//}

	}
}
