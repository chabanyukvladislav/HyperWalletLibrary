using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Component;
using Server.Component.Payments;
using Server.Database.Model;

namespace Server.Api
{
    public class PaymentApiWorker : IApiWorker<Payment>
    {
        private readonly HyperWalletLibrary.Api.Payment _api;
        private readonly PaymentToApiPaymentConverter _paymentToApiPayment;
        private readonly ResponseApiPaymentToListPaymentConverter _responseApiPaymentToListPayment;

        public PaymentApiWorker()
        {
            _api = new HyperWalletLibrary.Api.Payment(Account.HyperWalletAccount);
            _paymentToApiPayment = new PaymentToApiPaymentConverter();
            _responseApiPaymentToListPayment = new ResponseApiPaymentToListPaymentConverter();
        }

        public async Task<List<Payment>> GetAsync()
        {
            try
            {
                HyperWalletLibrary.Model.Response<HyperWalletLibrary.Model.Payment> response = await _api.GetAsync();
                _responseApiPaymentToListPayment.Content = response;
                List<Payment> list = _responseApiPaymentToListPayment.Convert();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Payment> GetAsync(string token)
        {
            try
            {
                HyperWalletLibrary.Model.Payment response = await _api.GetAsync(token);
                Payment payment = new Payment(response);
                return payment;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Payment> PostAsync(Payment item)
        {
            try
            {
                _paymentToApiPayment.Content = item;
                HyperWalletLibrary.Model.Payment newItem = _paymentToApiPayment.Convert();
                HyperWalletLibrary.Model.Payment response = await _api.PostAsync(newItem);
                Payment payment = new Payment(response);
                return payment;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<Payment> PutAsync(string token, Payment value)
        {
            return null;
        }
    }
}
