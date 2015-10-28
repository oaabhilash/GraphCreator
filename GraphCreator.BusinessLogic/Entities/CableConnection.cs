using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.BusinessLogic.Entities
{
    public class CableConnection
    {
        public NodeEquipment SourceEquipment { get; set; }
        public string CableName { get; set; }
        public string CableCode { get; set; }
        public NodeEquipment DestinationEquipment { get; set; }
    }
}
