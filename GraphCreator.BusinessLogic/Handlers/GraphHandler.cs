using GraphCreator.BusinessLogic.interfaces;
using GraphCreator.DataAccess.Entities;
using GraphCreator.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.BusinessLogic.Handlers
{
    public class GraphHandler : IGraphHandler
    {
        ICircuitRepository circuitRepository;
        IGraph graph;

        public GraphHandler(ICircuitRepository circuitRepository, IGraph graph)
        {
            this.circuitRepository = circuitRepository;
            this.graph = graph;
        }

        public void CreateGraph(string circuitId)
        {
            if(string.IsNullOrWhiteSpace(circuitId))
            {
                throw new ArgumentException("Invalid Circuit Id was passed");
            }

            List<CircuitRecord> circuitRecords = circuitRepository.GetGetEquipmentList(circuitId);

            foreach(CircuitRecord circuitRec in circuitRecords)
            {
                graph.AddNode(circuitRec);
            }


            
            
        }
    }
}
