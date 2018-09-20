namespace HyperWalletLibrary.Components
{
    public class HyperWalletAccount : IHyperWalletAccount
    {
        public IHyperWalletProgram Main { get; set; }
        public IHyperWalletProgram Card { get; set; }
        public IHyperWalletProgram Direct { get; set; }
        public IHyperWalletProgram Portal { get; set; }
        public IHyperWalletProgram Select { get; set; }
    }
}
