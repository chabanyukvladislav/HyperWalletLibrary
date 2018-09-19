using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    public interface IHyperWalletModel
    {
        List<Link> Links { get; set; }
    }
}