using System;
using Microsoft.AspNet.Identity;

namespace AspNetIdentityWithoutADatabase.WebApplication.Models
{     
    public class ApplicationUser : IUser
    {                   
        public string Id { get; set; }
        public string UserName { get; set; }
    }
 
}