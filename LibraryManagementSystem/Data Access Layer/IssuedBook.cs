﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Access_Layer
{
    class IssuedBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookIssueDate { get; set; }
    }
}
