using System;
using System.Collections.Generic;
using System.Text;
using DBStructure.Data.Exceptions;
using DBStructure.Data.Models;
using DBStructure.Data.Metods;
using System.Linq;
using DBStructure.Data.DAL;

namespace DBStructure.Data.Metods
{
    class UserMet
    {
        StoreDbContext StoreDbContext = new StoreDbContext();
        UserMet userMet = new UserMet();
        public void CheckUser(User user)
        {
            var users = StoreDbContext.User.Where(x => x.Username == user.Username || x.Email == user.Email).ToList();
            if (users.Count > 0)
            {
                throw new DataIsAlreadyExistsException("Bu user adi veya emaili  movcuddur ddd");
            }
            else
            {
                userMet.AddUser(user);
            }
        }

        public void CheckIdUser(int id)
        {
            var user = StoreDbContext.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                userMet.GetCommentsByUserId(id);
            }
            else
            {
                throw new NotFoundException("Bele bir user yoxdur!");
            }
        }
    }
}
