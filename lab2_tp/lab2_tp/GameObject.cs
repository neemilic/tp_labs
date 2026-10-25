using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_tp
{
    public abstract class GameObject
    {
        public int GetId { get; }
        public string GetName { get; }
        public int GetX { protected set; get; }
        public int GetY { protected set; get; }

        public GameObject(int id, string name, int x, int y)
        {
            GetId = id; 
            GetName = name;
            GetX = x;
            GetY = y;
        }
    }
}
