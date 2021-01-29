using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealSchedule.Domain.Models
{
    public class Agenda : BaseEntity
    {
        public string Nome { get; set; }
        public Usuario Usuario { get; set; }
        public List<Evento> Eventos { get; set; }
        [NotMapped]
        public int IdUser { get; set; }
    }
}