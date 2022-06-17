using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{

        public class Lecturers
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public int[] languages { get; set; }
        }

        public class Languages
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
}
