using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_tp
{
    public abstract class Unit : GameObject
    {
        private float _hp;
        public float GetHp => _hp;
        public bool IsAlive => _hp > 0;
        public Unit(int id, string name, int x, int y, float hp) : base(id, name, x, y)
        {
            _hp = hp;
        }
        public void ReceiveDamage(float damage)
        {
            if (damage < 0) return;
            _hp = Math.Max(0, _hp - damage);
        }
    }
}
