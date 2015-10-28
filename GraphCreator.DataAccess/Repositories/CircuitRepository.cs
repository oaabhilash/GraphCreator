using GraphCreator.DataAccess.Entities;
using GraphCreator.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.DataAccess.Repositories
{
    public class CircuitRepository : ICircuitRepository
    {

        public List<CircuitRecord> GetGetEquipmentList(string circuitId)
        {
            List<CircuitRecord> equipmentList = new List<CircuitRecord>();

            //create initial trunc

            for(int i = 1; i < 10;i++)
            {
                CircuitRecord rec1 = new CircuitRecord();
                rec1.CableId = "CM0" + i;
                rec1.CableName = "M0" + i;
                rec1.SourceEquipmentId = "Eq0" + (i-1);
                rec1.SourceEquipmentName = "SourceEq0" + (i-1);
                rec1.DestinationEquipmentId = "Eq0" + i; 
                rec1.DestinationEquipmentName = "SourceEq0" + i;
                equipmentList.Add(rec1);
            }

            return equipmentList;
        }

    }
}
