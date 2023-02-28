using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCloud.Store.Application.Dtos
{
    public class EmployeeForListDto
    {
        public int Id { get; set; }

        public string FirsName { get; set; }

        public string LastName { get; set; }

    }
}
