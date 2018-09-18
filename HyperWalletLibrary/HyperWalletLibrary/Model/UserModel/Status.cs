using System;

namespace HyperWalletLibrary.Model.UserModel
{
    [Serializable]
    public enum Status
    {
        PRE_ACTIVATED,
        ACTIVATED,
        LOCKED,
        FROZEN,
        DE_ACTIVATED
    }
}