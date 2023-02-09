using AutoMapper;
using SLM.Bussiness.Models;
using SLM.Data.Models;

namespace SLM.Bussiness.DataServices
{
	//profile is class form of automapper
	public class BussinessEntityMappings : Profile
	{
		//initialize the mapping inside of the constructor
		public BussinessEntityMappings()
		{
			//convert easily from product to model and viceversa
			CreateMap<CoursesModel, Courses>().ReverseMap();
			CreateMap<LectureModel, Lecture>().ReverseMap();
			CreateMap<UserModel, User>().ReverseMap();

		}

	}
}
