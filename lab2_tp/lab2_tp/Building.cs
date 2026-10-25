using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_tp
{
    public abstract class Building : GameObject
    {
        public Building(int id, string name, int x, int y, bool isBuilt) : base(id, name, x, y)
        {
            IsBuilt = isBuilt;
        }
        public bool IsBuilt { get; private set; }
    }
}
