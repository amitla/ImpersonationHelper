# ImpersonationHelper
Allows easy one-line impersonation for .Net apps using credentials from the windows credential store

###usage:

```csharp
// Credentials should be saved in the Domain\user.name format
using (new ImpersonationHelper.ImpersonationHelper("<NAME OF CREDETIAL AS APPEARS IN WINDOWS CREDENTIAL STORE>"))
{
    // do stuff here while imersonated
}
```