using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;
using XamarinClient.Collections;
using XamarinClient.Models;

namespace XamarinClient.Components
{
    class TokenToEmailConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            string token = value.ToString();
            User user = UserCollection.Collection.FirstOrDefault(el => el.Token == token);
            if (user != null)
                return user.Email;
            return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;
            string email = value.ToString();
            User user = UserCollection.Collection.FirstOrDefault(el => el.Email == email);
            if (user != null)
                return user.Token;
            return "";
        }
    }
}
