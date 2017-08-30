using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    [Serializable]
    class StudentsList
    {
        public List<Student> Students { get; set; }
    }
}
