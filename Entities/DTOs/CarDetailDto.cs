using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int CarName { get; set; }
        public int CategoryId { get; set; }
        public int Cate { get; set; }
        public int MyProperty { get; set; }

    }
}
