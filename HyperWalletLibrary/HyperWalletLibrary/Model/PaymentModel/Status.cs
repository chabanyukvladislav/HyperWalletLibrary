namespace HyperWalletLibrary.Model.PaymentModel
{
    enum Status
    {
        CREATED,
        SCHEDULED,
        PENDING_ACCOUNT_ACTIVATION,
        PENDING_TAX_VERIFICATION,
        PENDING_TRANSFER_METHOD_ACTION,
        PENDING_TRANSACTION_VERIFICATION,
        IN_PROGRESS,
        COMPLETED,
        CANCELLED,
        FAILED,
        RECALLED,
        RETURNED,
        EXPIRED
    }
}
