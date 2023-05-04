using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyStoreAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private static List<UserDataTransferObj> listUsers = new List<UserDataTransferObj>() {
            new UserDataTransferObj()
            {
                Firstname = "Ishi",
                Lastname = "Peter",
                Nickname = "PaChristmas",
                Mobilenumber = "+225557899",
                Email = "jp@unikblendz.com",
                Address = "Miami, FL, USA",
            },
            new UserDataTransferObj()
            {
                Firstname = "Sim",
                Lastname = "Segun",
                Nickname = "Serge",
                Mobilenumber = "+225557898",
                Email = "so@unikblendz.com",
                Address = "Miami, FL, USA",
            }
        };

        [HttpGet]
        public IActionResult GetUsers()
        {
            if (listUsers.Count > 0)
            {
                return Ok(listUsers);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                return Ok(listUsers[id]);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AddUser(UserDataTransferObj user)
        {
            listUsers.Add(user);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDataTransferObj user)
        {
            if(id >= 0 && id < listUsers.Count)
            {
                listUsers[id] = user;
            }

            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                listUsers.RemoveAt(id);
            }
        }
    }
}

