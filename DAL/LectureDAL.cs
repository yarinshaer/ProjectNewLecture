using BO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace DAL
{
    [EnableCorsAttribute("*", "*", "*")]
    public class LectureDAL
    {

        JObject data = JObject.Parse(File.ReadAllText(@"C:\Users\yarin\Desktop\lecture.json"));
        public List<Lecturers> GetLectures()
        {
            try
            {

                List<Lecturers> listcm = new List<Lecturers>();
                for (int i = 0; i < data["Lecturers"].Count(); i++)
                {

                    listcm.Add(new Lecturers
                    {
                        Email = data["Lecturers"][i]["email"].ToString(),
                        Id = Convert.ToInt32(data["Lecturers"][i]["id"]),
                        Name = data["Lecturers"][i]["name"].ToString(),
                        languages = data["Lecturers"][i]["languages"],
                        languagesName = data["Languages"][i]["name"].ToArray()
                    });

                }
                return listcm;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public List<Languages> GetLenguages()
        {
            try
            {
                List<Languages> listcm = new List<Languages>();
                for (int i = 0; i < data["Languages"].Count(); i++)
                {
                    listcm.Add(new Languages
                    {
                        Id = Convert.ToInt32(data["Languages"][i]["id"]),
                        Name = data["Languages"][i]["name"].ToString(),
                    });
                }
                return listcm;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
