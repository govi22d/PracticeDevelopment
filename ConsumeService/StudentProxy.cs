using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfStudentService;

namespace ConsumeService
{
    public class StudentServiceProxy : ClientBase<IStudentService>, IStudentService
    {
        public string GetStudentInfo(int studentId)
        {
            return base.Channel.GetStudentInfo(studentId);
        }
    }
}
