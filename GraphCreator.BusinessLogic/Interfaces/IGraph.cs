using GraphCreator.DataAccess.Entities;

namespace GraphCreator.BusinessLogic.interfaces
{
    public interface IGraph
    {
        string CircuitId { get; set; }

        void AddNode(CircuitRecord circuitRecord);
    }
}