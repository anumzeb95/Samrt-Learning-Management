﻿using SLM.Data.Interfaces;
using SLM.Data.Models;

namespace SLM.Data
{
	public class UserRepository : Repository<User>, IUserRepository

	{
		public UserRepository(SLManagementDbContext context) : base(context)
		{

		}

	}
}
