using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_tp
{
    public class Archer : Unit, IAttacker, IMoveable
    {
        private readonly float _damage;
        public float Damage => _damage;
        public Archer(int id, string name, int x, int y, float hp, float damage) :
            base(id, name, x, y, hp)
        {
            _damage = damage;
        }

        public void Attack(Unit unit)
        {
            if (IsAlive && unit.IsAlive) unit.ReceiveDamage(_damage);
        }

        public void Move(int x, int y)
        {
            if (IsAlive) { GetX = x; GetY = y; }
        }
    }
}
