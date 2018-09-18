using System;
using System.Collections.Generic;

namespace HyperWalletLibrary.Model
{
    [Serializable]
    public class Link
    {
        public KeyValuePair<string,string> Params { get; set; }
        public string Href { get; set; }
    }
}