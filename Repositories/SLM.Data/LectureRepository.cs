using SLM.Data.Interfaces;
using SLM.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLM.Data
{
    public class LectureRepository : Repository<Lecture>, ILectureRepository
    {
        public LectureRepository(SLManagementDbContext context) : base(context)
        {

        }

    }
}
