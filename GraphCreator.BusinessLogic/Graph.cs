using GraphCreator.BusinessLogic.Entities;
using GraphCreator.BusinessLogic.interfaces;
using GraphCreator.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.BusinessLogic
{
    public class Graph : IGraph
    {
        Dictionary<string, NodeEquipment> graphIndex;
        List<NodeEquipment> rootNodes;

        public string CircuitId { get; set; }

        

        public Graph(string circuitId)
        {
            graphIndex = new Dictionary<string, NodeEquipment>();
            rootNodes = new List<NodeEquipment>();
            this.CircuitId = circuitId;
        }

     

        public void AddNode(CircuitRecord circuitRecord)
        {
            NodeEquipment sourceEquipment = null;
            NodeEquipment destinationEquipment = null;
            
            sourceEquipment = CreateNodeEquipment(circuitRecord.SourceEquipmentId, circuitRecord.SourceEquipmentName);
            destinationEquipment = CreateNodeEquipment(circuitRecord.DestinationEquipmentId, circuitRecord.DestinationEquipmentName);

            CableConnection cable = new CableConnection()
            {
                CableCode = circuitRecord.CableId,
                CableName = circuitRecord.CableName,
                DestinationEquipment = destinationEquipment,
                SourceEquipment = sourceEquipment
            };

            sourceEquipment.ChildConnectionSet.Add(cable);
            destinationEquipment.ParentConnectionSet.Add(cable);
            
            

        }

        private NodeEquipment CreateNodeEquipment(string equipmentId, string equipmentName)
        {
            NodeEquipment equipment = null;

            if (graphIndex.ContainsKey(equipmentId))
            {
                graphIndex.TryGetValue(equipmentId, out equipment);
            }
            else
            {
                equipment = new NodeEquipment()
                {
                    EquipmentId = equipmentId,
                    EqipmentName = equipmentName
                };

                graphIndex.Add(equipmentId, equipment);

            }

            return equipment;

        }

    }
}
