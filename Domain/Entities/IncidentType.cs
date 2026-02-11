using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class IncidentType : BaseEntityId
    {
        public string Name { get; set; }
        public ICollection<Ambit> Ambits { get; set; } = new HashSet<Ambit>();
        public ICollection<Incident> Incidents { get; set; } = new HashSet<Incident>();
    }
}
