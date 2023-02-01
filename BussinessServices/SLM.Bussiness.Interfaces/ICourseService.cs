﻿using SLM.Bussiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM.Bussiness.DataServices.Interfaces
{
    public interface ICourseService
    {
        List<CoursesModel> GetAll();

        public void Add(CoursesModel model);
        public void Details( int Id);
        public void Delete(int Id)
            ;
    }
}
