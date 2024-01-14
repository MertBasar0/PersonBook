using DataAccess.Abstract;
using Entities;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly UserManager<AppUser> _userManager;
        public readonly SignInManager<AppUser,int> _signInManager;

        public UserRepository(UserManager<AppUser> userManager, Microsoft.AspNet.Identity.Owin.SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public Task<AppUser> CreateUser()
        {
            return null;
        }

        public Task<List<AppUser>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetUserInActiveByData(AppUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SetUserInActiveById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> UpdateUserByData(AppUser user)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> UpdateUserById(AppUser user)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> UpdateUserByIdAndData(int id, AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
