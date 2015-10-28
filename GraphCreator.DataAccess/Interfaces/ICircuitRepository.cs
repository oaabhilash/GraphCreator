using System.Collections.Generic;
using GraphCreator.DataAccess.Entities;

namespace GraphCreator.DataAccess.Interfaces
{
    public interface ICircuitRepository
    {
        List<CircuitRecord> GetGetEquipmentList(string circuitId);
    }
}