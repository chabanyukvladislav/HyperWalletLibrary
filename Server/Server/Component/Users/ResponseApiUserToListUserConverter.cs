﻿using System.Collections.Generic;
using Server.Database.Model;

namespace Server.Component
{
    public class ResponseApiUserToListUserConverter : IResponseApiUserConverter<List<User>>
    {
        public HyperWalletLibrary.Model.Response<HyperWalletLibrary.Model.User> Content { get; set; }

        public List<User> Convert()
        {
            if (Content == null) return null;
            List<User> list = new List<User>();
            foreach (HyperWalletLibrary.Model.User apiUser in Content.Data)
            {
                User user = new User(apiUser);
                list.Add(user);
            }

            return list;
        }

        public ResponseApiUserToListUserConverter(
            HyperWalletLibrary.Model.Response<HyperWalletLibrary.Model.User> content = null)
        {
            Content = content;
        }
    }
}
