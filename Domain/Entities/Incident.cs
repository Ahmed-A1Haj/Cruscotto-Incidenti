using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Incident : AuditableEntityId
    {
        public string RequestNr { get; set; }
        public string Subsystem { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Type { get; set; }
        public string AplicationType { get; set; }
        public string Urgency { get; set; }
        public string SubCause { get; set; }
        public string ProblemSummery { get; set; }
        public string ProblemDescription { get; set; }
        public string Solution { get; set; }
        public User CreatedBy { get; set; }
        public User LastModifiedBy { get; set; }
        public int IncidentTypeId { get; set; }
        public IncidentType IncidentType { get; set; }
        public int AmbitId { get; set; }
        public Ambit Ambit { get; set; }
        public int OriginId { get; set; }
        public Origin Origin { get; set; }
        public int ScenarioId { get; set; }
        public Scenario Scenario { get; set; }
        public int ThreatId { get; set; }
        public Threat Threat { get; set; }
        public bool IsDeleted { get; set; }

    }
}
