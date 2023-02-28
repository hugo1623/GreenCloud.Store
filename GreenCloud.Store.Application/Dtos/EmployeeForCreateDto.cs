using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCloud.Store.Application.Dtos
{
    public class EmployeeForCreateDto
    {

        public string FirsName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
    }
}
