﻿using HolidayManagement.Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace HolidayManagement.Repository
{
    public class UserDetailsRepository : BaseRepository<UserDetails>, IUserDetailsRepository
    {
        public UserDetails GetUserDetailsById(int userDetailsId)
        {
            return DbContext.Users.FirstOrDefault(x => x.ID == userDetailsId);
        }

        public List<UserDetails> GetUsers()
        {
            return DbContext.Users.ToList();
        }
    }
}
