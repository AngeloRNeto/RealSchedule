using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealSchedule.Domain.Models
{
    public class Evento : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}