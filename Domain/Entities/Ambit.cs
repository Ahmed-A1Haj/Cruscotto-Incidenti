using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ambit : BaseEntityId
    {
        public string Name { get; set; }
        public ICollection<Origin> Origins { get; set; } = new HashSet<Origin>();
        public ICollection<IncidentType> IncidentTypes { get; set; } = new HashSet<IncidentType>();
        public ICollection<Incident> Incidents { get; set; } = new HashSet<Incident>();
    }
}
