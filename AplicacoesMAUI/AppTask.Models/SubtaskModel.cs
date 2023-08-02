using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AppTask.Models
{
    public class SubtaskModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public bool IsCompleted { get; set; }
    }
}
