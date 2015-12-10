using System;
using System.Configuration;
using JohnnyCode.GitHubOAuth2;
using Microsoft.Web.WebPages.OAuth;

[assembly: WebActivator.PostApplicationStartMethod(typeof(DataDemo.App_Start.AuthConfigGitHub), "PostStart")]

namespace DataDemo.App_Start
{
    public static class AuthConfigGitHub
    {
        public static void PostStart()
        {
            RegisterAuth();
        }

        public static void RegisterAuth()
        {
            OAuthWebSecurity.RegisterClient(new GitHubOAuth2Client(ConfigurationManager.AppSettings["GitHub.ClientId"], ConfigurationManager.AppSettings["GitHub.ClientSecret"]), "GitHub", null);
        }
    }
}