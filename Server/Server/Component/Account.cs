using HyperWalletLibrary.Components;

namespace Server.Component
{
    public static class Account
    {
        public static IHyperWalletAccount HyperWalletAccount
        {
            get
            {
                IHyperWalletAccount account = new HyperWalletAccount
                {
                    Main = new HyperWalletProgram()
                    {
                        Password = "Ke002308!!",
                        ProgramToken = "prg-91b2bb2f-88c4-4a5d-b6ae-ef24b25567a3",
                        Username = "restapiuser@15472201613"
                    },
                    Portal = new HyperWalletProgram()
                    {
                        Password = "Ke002308!!",
                        ProgramToken = "prg-a3054235-6b29-432a-a01e-47ff2d944941",
                        Username = "restapiuser@15472221611"
                    },
                    Card = new HyperWalletProgram()
                    {
                        Password = "Ke002308!!",
                        ProgramToken = "prg-1ffcbcc8-b522-496b-9869-798359a03474",
                        Username = "restapiuser@15472271616"
                    },
                    Direct = new HyperWalletProgram()
                    {
                        Password = "Ke002308!!",
                        ProgramToken = "prg-a90623d1-fc8f-4759-9388-5bd3ff12591e",
                        Username = "restapiuser@15472301611"
                    },
                    Select = new HyperWalletProgram()
                    {
                        Password = "Ke002308!!",
                        ProgramToken = "prg-514cb3c6-a329-4721-abde-e80f36872cdc",
                        Username = "restapiuser@15472241619"
                    }
                };
                return account;
            }
        }
    }
}
