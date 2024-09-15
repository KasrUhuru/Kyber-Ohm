using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyberOhm.Entities
{
    public class BattleFunction
    {
        public int FunctionID { get; set; }

        public DamageType Type { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Damage {  get; set; }
        public int MaxDamage { get; set; }
        public int Accuracy { get; set; }
    }
}
