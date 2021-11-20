namespace AzureAdb2cDemo
{
    internal static class Constants
    {
        internal static readonly string TenantName = "sandysruthib2c";

        internal static readonly string TenantId = "d5eb2724-ab28-4a30-998e-de8b5a6f8744";

        internal static readonly string ClientId = "08813d26-3308-4fd6-a941-cb5b04d68c21";

        internal static readonly string PolicySignin = "b2c_1_sandyflow";

        internal static readonly string[] Scopes = { "" };

        internal static readonly string AuthorityBase = $"https://{TenantName}.b2clogin.com/tfp/{TenantId}/";

        internal static string AuthoritySignin => $"{AuthorityBase}{PolicySignin}";

        internal static string RedirectUri = $"msauth://com.sandy.azureadauthenticationdemo/in%2FAfV20SjPwJmYPjMdaTzdpe68%3D";
    }
}
