using RealSchedule.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealSchedule.Domain.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Situacao Situacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}