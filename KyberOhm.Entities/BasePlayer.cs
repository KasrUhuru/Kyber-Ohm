using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyberOhm.Entities
{
    public abstract class BasePlayer
    {
        public string Name { get; set; }

        /// <summary>
        /// All droids, drones, and dregs in storage or reserve
        /// No maximum size fleet yet
        /// </summary>
        public virtual IList<Construct>? Fleet {  get; set; }

        /// <summary>
        /// The number of constructs that can be effectively
        /// managed by a given unit. Temporary 3-unit limit
        /// </summary>
        public virtual IList<Construct>? Squad { get; set; }
    }
}
