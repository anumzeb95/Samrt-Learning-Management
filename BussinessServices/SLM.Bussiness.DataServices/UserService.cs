
using AutoMapper;
using SLM.Bussines.Interfaces;
using SLM.Data.Interfaces;
using SLM.WebApp.Models;

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