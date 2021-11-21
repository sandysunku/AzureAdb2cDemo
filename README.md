# AzureAdb2cDemo
Xamarin Forms application that authenticates using Azure ADB2C 

## What is Azure ADB2C
Azure Active Directory B2C (Azure AD B2C) is an identity management service that enables custom control of how your customers sign up, sign in, and manage their profiles when using your iOS, Android, . NET, single-page (SPA), and other applications.

## Details that needs to be added to Constants class
1. TenantName: Tenant name that is provided during adb2c tenant creation // Example "sandeepb2c"
2. TenantId: Tenant Id that gets created after successful creation of Adb2c tenant. // Example: d5eb5724-ab29-4a30-998f-de8b2a6f5743
3. ClientId: Client Id that gets created after successful creation of tenant. // Example: 08833d26-3308-4fd6-b941-ck5b04d38h21
4. PolicySignin: Name of the sign wokflow that you have created in adb2c for login and sign in. // Example: b2c_1_sandeepflow
5. RedirectUri: Uri to return to your application once authentication is completed successfully. // Example: msauth://your application package name/in%2FAfS20SjPkJmYPjDdaTzdpe68%3D
The last part is the SHS key that is generated using your command prompt.

### Note: ADB2C tenant creation in Azure is not covered here.
