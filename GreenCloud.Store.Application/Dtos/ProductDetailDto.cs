﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCloud.Store.Application.Dtos
{
    public class ProductDetailDto
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }
        public string Descripcion { get; set; }

        public int Stock { get; set; }
    }
}
