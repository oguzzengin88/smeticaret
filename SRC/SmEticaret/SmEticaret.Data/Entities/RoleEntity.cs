﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmEticaret.Data.Entities
{
    public class RoleEntity : EntityBase
    {
        public int RoleId { get; set; }

        [Required]
        [MaxLength(10)]
        public string Name { get; set; }

    }
}
