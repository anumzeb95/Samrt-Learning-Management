
using AutoMapper;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data.Interfaces;
using SLM.Data.Models;


namespace SLM.Bussiness.DataServices
{
	public class UserService : GenericService<UserModel, User>, IUserService
	{
		private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }

        
    }
}