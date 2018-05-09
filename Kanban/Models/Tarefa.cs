using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kanban.Models
{
    public class Tarefa
    {
        public string Nome{ get; set; }
        public int Status { get; set; }
        public int Id { get; set; }
        public Tarefa Dependencia { get; set; }
    }
}