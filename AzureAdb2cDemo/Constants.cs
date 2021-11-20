namespace AzureAdb2cDemo
{
    internal static class Constants
    {
        // Fill all the required details here after creating azure adb2c tenant
        internal static readonly string TenantName = "";

        internal static readonly string TenantId = "";

        internal static readonly string ClientId = "";

        internal static readonly string PolicySignin = "";

        internal static readonly string[] Scopes = { "" };

        internal static readonly string AuthorityBase = $"https://{TenantName}.b2clogin.com/tfp/{TenantId}/";

        internal static string AuthoritySignin => $"{AuthorityBase}{PolicySignin}";

        internal static string RedirectUri = "";
    }
}
