using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Students.Model
{
    public class XmlFileService : IFileService
    {
        public List<Student> Open(string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(StudentsList));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                StudentsList list = (StudentsList)formatter.Deserialize(fs);
                return list.Students;
            }
        }

        public void Save(string filename, List<Student> studentList)
        {
            StudentsList list = new StudentsList();
            list.Students = studentList;
            XmlSerializer formatter = new XmlSerializer(typeof(StudentsList));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }
}
