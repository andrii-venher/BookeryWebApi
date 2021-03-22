﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookeryWebApi.Models
{
    public class BlobDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid IdContainer { get; set; }
    }
}
