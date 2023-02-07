
using AutoMapper;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data;
using SLM.Data.Interfaces;
using SLM.Data.Models;
using SLM.WebApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace SLM.Bussiness.DataServices
{ 
        public class UserService: GenericService<UserModel, User> , IUserService
    {
    
        private readonly IRepository<Lecture> _repository;
        public UserService(IRepository<Lecture> repository, IMapper mapper) : base(repository, mapper)
        {
            _repository = repository;
        }



    }


}