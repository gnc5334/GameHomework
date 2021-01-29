using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public interface IUserService
    {
        void Add(User person);
        void Update(User person);
        void Delete(User person);
        void List();
    }
}
