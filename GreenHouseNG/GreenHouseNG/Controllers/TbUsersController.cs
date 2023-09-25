using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GreenHouseNG.Data;
using AutoMapper;
using GreenHouseNG.Models.User;

namespace GreenHouseNG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TbUsersController : ControllerBase
    {
        private readonly DbgreenhouseNgContext _context;
        private readonly IMapper mapper;

        public TbUsersController(DbgreenhouseNgContext context,IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        // GET: api/TbUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbUser>>> GetTbUsers()
        {
          if (_context.TbUsers == null)
          {
              return NotFound();
          }
            var listtDescription = await _context.TbUsers
                  .Join(_context.TbRoles, u => u.IdRole, R => R.IdRole, (u, R) => new { u, R })
                  .Select(S => new UserReadOnlyDto
                  {
                        IdUser = S.u.IdUser,

                        Uname = S.u.Uname,

                        UserRole = S.R.RoleDescription,

                        FirstName= S.u.FirstName,

                        LastName = S.u.LastName

                   })
                  .ToListAsync();
           
            return Ok(listtDescription);






            //This is just a pattern for joining 
            /* .Join(_context.TbRoles, u => u.IdRole, R => R.IdRole, (u, R) => new { u, R })
                //.Where(uR=>uR.R.RoleDescription)
                .Select(s => new calssname
                {
                    prop = s.u.FirstName + " " + s.u.LastName,
                    ApiD=
                });
                .ToListAsync();*/
        }

        // GET: api/TbUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbUser>> GetTbUser(int id)
        {
          if (_context.TbUsers == null)
          {
              return NotFound();
          }
            var tbUser = await _context.TbUsers.FindAsync(id);

            var listtDescription = await _context.TbUsers
                   .Join(
                    _context.TbRoles,
                    u => u.IdRole,
                    R => R.IdRole,
                   (u, R) => new { u, R } )
                   .Where(uR => uR.u.IdUser == id) 
                   .Select(s => s.R.RoleDescription)
                   .ToListAsync();

           

            if (tbUser == null)
            {
                return NotFound();
            }

            return Ok(listtDescription);
        }

        // PUT: api/TbUsers/5
       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbUser(int id, TbUser tbUser)
        {
            if (id != tbUser.IdUser)
            {
                return BadRequest();
            }

            _context.Entry(tbUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TbUsers
        [HttpPost]
        public async Task<ActionResult<UserCreateDto>> PostTbUser(UserCreateDto tbuser)
        {
            var tbUser = mapper.Map<TbUser>(tbuser);
          if (_context.TbUsers == null)
          {
              return Problem("Entity set 'DbgreenhouseNgContext.TbUsers'  is null.");
          }
            _context.TbUsers.Add(tbUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTbUser", new { id = tbUser.IdUser }, tbUser);
        }

        // DELETE: api/TbUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbUser(int id)
        {
            if (_context.TbUsers == null)
            {
                return NotFound();
            }
            var tbUser = await _context.TbUsers.FindAsync(id);
            if (tbUser == null)
            {
                return NotFound();
            }

            _context.TbUsers.Remove(tbUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbUserExists(int id)
        {
            return (_context.TbUsers?.Any(e => e.IdUser == id)).GetValueOrDefault();
        }
    }
}
