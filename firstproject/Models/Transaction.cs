using System;
using System.Collections.Generic;

#nullable disable

namespace firstproject.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public DateTime? Date { get; set; }
    }
}
