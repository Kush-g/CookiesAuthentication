using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class EmailAccount
	{
		public int Id { get; set; }
		public string DisplayName { get; set; }
		public string Email { get; set; }
		public string Host { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int Port { get; set; }
		public bool EnableSsl { get; set; }
		public bool UseDefaultCredentials { get; set; }
	}
	public class ExternalAuthenticationRecord
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public string Email { get; set; }
		public string ExternalIdentifier { get; set; }
		public string ExternalDisplayIdentifier { get; set; }
		public string OAuthToken { get; set; }
		public string OAuthAccessToken { get; set; }
		public string ProviderSystemName { get; set; }
	}
}
