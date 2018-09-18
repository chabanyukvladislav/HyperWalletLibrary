using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    internal interface IApiModel
    {
        IEnumerable<Link> Links { get; set; }
    }
}