using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System;
using WeatherApp.Data.Entities;
using WeatherApp.Helpers;

namespace WeatherApp.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
           

            //Add User Admin when create db
            var userAdmin = await _userHelper.GetUserByEmailAsync("CatiaSantos@gmail.com");
            if (userAdmin == null)
            {
                userAdmin = new User
                {
                    Email = "CatiaSantos@gmail.com",
                    UserName = "CatiaSantos@gmail.com",
                    Password = "Catia0202",
                    FirstName = "Catia",
                    LastName = "Santos"
                };
                var result1 = await _userHelper.AddUserAsync(userAdmin, "Catia0202");
                if (result1 != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user  in seeder");
                }
               
            }
           
        }
    }
}
