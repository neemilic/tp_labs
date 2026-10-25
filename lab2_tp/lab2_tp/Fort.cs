using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_tp
{
    public class Fort : Building, IAttacker
    {
        private readonly float _damage;
        public float Damage => _damage;
        public Fort(int id, string name, int x, int y, bool isBuilt, float damage) :
            base(id, name, x, y, isBuilt)
        {
            _damage = damage;
        }

        public void Attack(Unit unit)
        {
            if (IsBuilt && unit.IsAlive) { unit.ReceiveDamage(_damage); }
        }
    }
}
