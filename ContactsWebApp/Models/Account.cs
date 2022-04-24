﻿using System;

namespace ContactsWebApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public string Address { get; set; }    
        public string  City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Account()
        {

        }

    }
}
