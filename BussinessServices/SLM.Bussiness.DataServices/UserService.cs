
using AutoMapper;
using SLM.Bussines.Interfaces;
using SLM.Bussiness.Models;
using SLM.Data.Interfaces;
using SLM.Data.Migrations;
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

        public UserModel GetProfile(int Id)
        {
            var Profile = _repository.Get(x=>x.Id == Id).FirstOrDefault();
            var UserProfile = new UserModel
            {
                Name = Profile.Name,
                Email = Profile.Email,
                Password = Profile.Password,
                DOB = Profile.DOB,
                Gender = Profile.Gender,
                Designation = Profile.Designation,
                Course = Profile.Course,
                Address = Profile.Address,
                Contact = Profile.Contact
            };
        
           return UserProfile;
        }
    }
}