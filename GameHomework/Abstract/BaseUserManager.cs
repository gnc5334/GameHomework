using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public abstract class BaseUserManager : IUserService
    {
        List<User> userList = new List<User>();
        public virtual void Add(User user)
        {
                userList.Add(user);
                Console.WriteLine(user.FirstName + " kayıt oldu");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı bilgisi silindi");
        }

        public virtual void List()
        {
            foreach (var userItem in userList)
                Console.WriteLine(userItem.FirstName + " " + userItem.LastName);

        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " güncellendi.");
        }
    }
}
