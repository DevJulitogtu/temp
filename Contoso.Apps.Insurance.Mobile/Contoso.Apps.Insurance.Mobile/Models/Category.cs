﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CIMobile.Models
{
    public class Category
    {
        public Category()
        {
            Name = Description = ImageUrl = ParentCategoryId = string.Empty;
            Sequence = 0;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string ParentCategoryId { get; set; }

        public bool HasSubCategories { get; set; }

        public int Sequence { get; set; }
    }
}
