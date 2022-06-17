using BL;
using BO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication23.Controllers
{

    [AllowCrossSiteJson]
   
    [EnableCorsAttribute("*", "*","*")]
    public class LectureApiController : ApiController
    {
       
        
        public int CheckDataIsEmpty(JObject data)
        {
            if (data == null)
                return 0;
            return 1;   
        }
        // GET: api/LectureApi
        [HttpGet]
        [Route("GetListLectures")]
        public List<Lecturers> GetListLectures()
        {

            try
            {
               LectureBL lectureBL = new LectureBL();
                var listLecture = lectureBL.GetLectures();
                return listLecture;
            }
            catch
            {
                return null;
            }
        }
        
        [HttpGet]
        [Route("GetListLenguages")]
        public List<Languages> GetListLenguages()
        {
            try
            {
                LectureBL lectureBL = new LectureBL();
                var listLenguages = lectureBL.GetLenguages();
                return listLenguages;
            }
            catch
            {
                return null;
            }
        }

    }
}
