using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDatingApp.Entities;
using MyDatingApp.Services;

namespace MyDatingApp.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser  user);
    }
}