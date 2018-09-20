namespace HyperWalletLibrary.Components
{
    public interface IHyperWalletAccount
    {
        IHyperWalletProgram Main { get; set; }
        IHyperWalletProgram Card { get; set; }
        IHyperWalletProgram Direct { get; set; }
        IHyperWalletProgram Portal { get; set; }
        IHyperWalletProgram Select { get; set; }
    }
}
