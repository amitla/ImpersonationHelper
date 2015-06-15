using System;
using CredentialManagement;
using SimpleImpersonation;

namespace ImpersonationHelper
{
    public class ImpersonationHelper : IDisposable
    {
        private const string DEFAULT_CREDENTIAL_NAME = "DEFAULT_IMPOERSONATION_HELPER";

        private Credential mCred; 
        private Impersonation mImpersonation;

        public  ImpersonationHelper(string credentialTargetName = DEFAULT_CREDENTIAL_NAME)
        {
            mCred = new Credential() { Target = credentialTargetName };
            if (mCred.Exists())
            {
                mCred.Load();
                var domain = mCred.Username.Split('\\')[0];
                var userName = mCred.Username.Split('\\')[1];
                var pass = mCred.Password;
                
                mImpersonation = Impersonation.LogonUser(domain, userName, pass, LogonType.NewCredentials);
            }
        }

        public void Dispose()
        {
            if (mCred != null)
            {
                mCred.Dispose();
            }

            if (mImpersonation != null)
            {
                mImpersonation.Dispose();
            }
        }
    }
}
