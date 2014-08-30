using System;
using Microsoft.AspNet.Identity;

namespace AspNetIdentityWithoutADatabase.WebApplication.Models
{
    public class CustomUserSore<T> : IUserStore<T> where T : ApplicationUser
    {

        System.Threading.Tasks.Task IUserStore<T>.CreateAsync(T user)
        {
            //Create /Register New User
            throw new NotImplementedException();
        }

        System.Threading.Tasks.Task IUserStore<T>.DeleteAsync(T user)
        {
            //Delete User
            throw new NotImplementedException();
        }

        System.Threading.Tasks.Task<T> IUserStore<T>.FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        System.Threading.Tasks.Task<T> IUserStore<T>.FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        System.Threading.Tasks.Task IUserStore<T>.UpdateAsync(T user)
        {
            //Update User Profile
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            // throw new NotImplementedException();

        }
    }
}