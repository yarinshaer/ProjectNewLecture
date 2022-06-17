using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace BL
{
    [EnableCorsAttribute("*", "*", "*")]
    public class LectureBL
    {
       

     
        public List<Lecturers> GetLectures() 
        {
            try
            {
                LectureDAL objLecture = new LectureDAL();   
                return objLecture.GetLectures();
            }
            catch
            {
                throw;
            }
        }

        public List<Languages> GetLenguages() 
        {
            try
            {
                LectureDAL objLenguages = new LectureDAL();  
                return objLenguages.GetLenguages();
            }
            catch
            {
                throw;
            }
        }

    }
}
