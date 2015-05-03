# ImpersonationHelper
Allows easy one-line impersonation for .Net apps using credentials from the windows credential store

###usage:

```csharp
using (new ImpersonationHelper.ImpersonationHelper("<NAME OF CREDETIAL AS APPEARS IN WINDOWS CREDENTIAL STORE>"))
{
    // do stuff here while imersonated
}
```

