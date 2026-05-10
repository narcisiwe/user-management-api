using System.Collections.Generic;

namespace UserManagementApi.Models
{
    public static class UserStore
    {
        public static List<User> Users = new List<User>
        {
            new User
            {
                Id = 1,
                Name = "John Doe",
                Email = "john@test.com",
                Age = 30
            }
        };
    }
}