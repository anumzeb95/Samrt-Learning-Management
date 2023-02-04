using AutoMapper;
using SLM.Bussiness.Models;
using SLM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM.Bussiness.DataServices
{
    //profile is class form of automapper
    public class BussinessEntityMappings :Profile
    {
        //initialize the mapping inside of the constructor
        public BussinessEntityMappings()
        {
            //convert easily from product to model and viceversa
            CreateMap<CoursesModel, Courses>().ReverseMap();
            CreateMap<LectureModel, Lecture>().ReverseMap();

        }

    }
}
