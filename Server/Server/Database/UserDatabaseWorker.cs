using System;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Server.Database
{
    public class UserDatabaseWorker : IDatabaseWorker<User>
    {
        private readonly Context _context;

        public UserDatabaseWorker(Context context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAsync()
        {
            return await Task.Run(() =>
            {
                try
                {
                    return _context.Users?.ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            });
        }

        public async Task<User> GetAsync(string clientUserId)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return _context.Users?.FirstOrDefault(el => el.Id == clientUserId);
                }
                catch (Exception)
                {
                    return null;
                }
            });
        }

        public async Task<bool> PostAsync(User item)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Users.Add(item);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        public async Task<bool> PutAsync(string clientUserId, User item)
        {
            return await Task.Run(() =>
            {
                try
                {
                    User user = _context.Users?.FirstOrDefault(el => el.Id == clientUserId);
                    if (user == null)
                        return false;
                    foreach (PropertyInfo property in typeof(User).GetProperties())
                    {
                        object value = property.GetValue(item);
                        if (value == null)
                            break;
                        property.SetValue(user, value);
                    }

                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }
    }
}
