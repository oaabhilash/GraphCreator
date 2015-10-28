using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.DataAccess.Entities
{
    public class CircuitRecord
    {
        public string CircuitId { get; set; }
        public string SourceEquipmentName { get; set; }

        public string SourceEquipmentId { get; set; }

        public string CableName { get; set; }
        public string CableId { get; set; }
        public string DestinationEquipmentId {get;set;}

        public string DestinationEquipmentName { get; set; }
    }
}
