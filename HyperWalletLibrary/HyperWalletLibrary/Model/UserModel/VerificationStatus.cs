using System;

namespace HyperWalletLibrary.Model.UserModel
{
    [Serializable]
    public enum VerificationStatus
    {
        NOT_REQUIRED,
        REQUIRED,
        UNDER_REVIEW,
        VERIFIED
    }
}