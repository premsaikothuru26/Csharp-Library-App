﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Magazine : Book
    {

        public int IssueNumber { get; set; }
        public Magazine(int IssueNumber, string Title, int PageCount, string MediaType) : base(PageCount, Title, MediaType)
        {
            this.IssueNumber = IssueNumber;
        }
    }
}
