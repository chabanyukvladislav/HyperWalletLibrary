using HyperWalletLibrary.Model;
using System;
using System.Collections.Generic;

namespace Server.Component.Payments
{
    public class ResponseApiPaymentToListPaymentConverter : IResponseApiPaymentConverter<List<Database.Model.Payment>>
    {
        public Response<Payment> Content { get; set; }

        public ResponseApiPaymentToListPaymentConverter(Response<Payment> content = null)
        {
            Content = content;
        }

        public List<Database.Model.Payment> Convert()
        {
            if (Content == null) return null;
            List<Database.Model.Payment> list = new List<Database.Model.Payment>();
            foreach (Payment payment in Content.Data)
            {
                Database.Model.Payment value = new Database.Model.Payment(payment);
                list.Add(value);
            }

            return list;
        }
    }
}
