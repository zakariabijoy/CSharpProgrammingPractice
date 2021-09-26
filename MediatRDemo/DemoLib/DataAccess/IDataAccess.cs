﻿using DemoLib.Models;
using System.Collections.Generic;

namespace DemoLib.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}