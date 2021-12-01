using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyDatingApp.Data;
using MyDatingApp.Entities;

namespace MyDatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser()
        {
            return await  _context.Users.ToListAsync();

        }



        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await  _context.Users.FindAsync(id);
        }

        // [HttpDelete("{id}")]

        // public ActionResult<AppUser> Delete(int id)
        // {
        //     var BookDelete = _context.
        // }
    }
}