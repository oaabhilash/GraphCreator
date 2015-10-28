using GraphCreator.BusinessLogic;
using GraphCreator.BusinessLogic.Handlers;
using GraphCreator.BusinessLogic.interfaces;
using GraphCreator.DataAccess.Interfaces;
using GraphCreator.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ICircuitRepository circuitRepo = new CircuitRepository();
            IGraph graph = new Graph("circuitid");

            IGraphHandler graphHandler = new GraphHandler(circuitRepo, graph);
            graphHandler.CreateGraph("circuitid");

        }
    }
}
