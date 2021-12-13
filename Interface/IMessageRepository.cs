using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyDatingApp.DTOs;
using MyDatingApp.Entities;
using MyDatingApp.Helpers;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MyDatingApp.Interface
{
    public interface IMessageRepository
    {
        // void AddGroup(Group group);
        // void RemoveConnection(Connection connection);
        // Task<Connection> GetConnection(string connectionId);
        // Task<Group> GetMessageGroup(string groupName);
        // Task<Group> GetGroupForConnection(string connectionId);
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<List<MessageDto>> GetMessageThread(string currentUsername, string RecipientUsername);
        Task<bool> SaveAllAsync();
    }
}