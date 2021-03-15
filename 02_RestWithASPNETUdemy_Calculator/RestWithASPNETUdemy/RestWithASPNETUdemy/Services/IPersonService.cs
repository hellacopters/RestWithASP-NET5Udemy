﻿using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services
{
    public interface IPersonService
    {
        Person Crete(Person person);
        Person FindById(long id);
        List <Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}