using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDatingApp.DTOs;
using MyDatingApp.Entities;
using MyDatingApp.Helpers;

namespace MyDatingApp.Interface
{
    public interface ILikesRepository
    {
          Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}