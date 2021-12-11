using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDatingApp.DTOs;
using MyDatingApp.Entities;
using MyDatingApp.Helpers;

namespace MyDatingApp.Interface
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto> GetMemberAsync(string username);
    }
}