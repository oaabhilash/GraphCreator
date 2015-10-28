using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphCreator.BusinessLogic.Entities
{
    public class NodeEquipment
    {
        List<CableConnection> _childConnections;
        List<CableConnection> _parentConnections;

        public NodeEquipment()
        {
            _childConnections = new List<CableConnection>();
            _parentConnections = new List<CableConnection>();
        }

        public string EqipmentName { get; set; }
        public List<CableConnection> ChildConnectionSet
        {
            get{ return _childConnections; }
        }
        
        public List<CableConnection> ParentConnectionSet
        {
            get { return _parentConnections; }
        }

        public string EquipmentId { get; set; }

        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }
    }
}
