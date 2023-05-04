using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private static List<string> listUsers = new List<string>() { "Nina", "Tina", "Jonah", "Sam" };

        [HttpGet]
        public List<string> GetUsers()
        {
            return listUsers;
        }

        [HttpGet("{id}")]
        public string GetUser(int id)
        {
            if (id >= 0 && id < listUsers.Count)
            {
                return listUsers[id];
            }
            return "";
        }

        [HttpPost]
        public void AddUser(string username)
        {
            listUsers.Add(username);
        }

        [HttpPut("{id}")]
        public void UpdateUser(int id, string username)
        {
            if(id >= 0 && id < listUsers.Count)
            {
                listUsers[id] = username;
            }
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

