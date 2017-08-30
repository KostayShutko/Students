using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    public interface IFileService
    {
        List<Student> Open(string filename);
        void Save(string filename, List<Student> studentList);
    }
}
