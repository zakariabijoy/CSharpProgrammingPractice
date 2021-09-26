﻿using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.DataAccess
{
    public class PeopleContext:DbContext
    {
        public PeopleContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> EmailAddress { get; set; }
    }
}
