namespace HyperWalletLibrary.Components
{
    public interface IHyperWalletProgram
    {
        string Username { get; set; }
        string Password { get; set; }
        string ProgramToken { get; set; }
    }
}