using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_WCF.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Done { get; set; }
    }
}
