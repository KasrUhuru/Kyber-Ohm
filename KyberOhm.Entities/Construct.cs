using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyberOhm.Entities
{
    public class Construct
    {
        /// <summary>
        /// Every droid, drone, and dreg is an Assembly
        /// An assembly is a collection of generic parts
        /// </summary>
        public int AssemblyID { get; set; }

        /// <summary>
        /// Construct type will affect its basic stats, functions, and size category
        /// </summary>
        public ConstructType Type { get; set; }

        public ConstructClass Designation { get; set; }

        /// <summary>
        /// Assembly-Generated factory name cannot be overidden
        /// </summary>
        public string? BaseName { get; set; }

        /// <summary>
        /// Optional name given by an owner
        /// </summary>
        public string? Nickname { get; set; }

        /// <summary>
        /// Is the construct running?
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Assess a construct's functionality
        /// Minimum conditions to activate are: HasPower, IsIntact
        /// </summary>
        public bool CanActivate { get; set; }

        /// <summary>
        /// Is a functional, compatible battery installed?
        /// </summary>
        public bool HasPower {  get; set; }

        /// <summary>
        /// Does it have more than 0 HP?
        /// </summary>
        public bool IsIntact {  get; set; }

        /// <summary>
        /// Unmodified SUM of Skill Levels
        /// </summary>
        public int BaseLevel { get; set; }

        /// <summary>
        /// SUM of Skill Levels + Upgrades
        /// </summary>
        public int EffectiveLevel { get; set; }


        /// <summary>
        /// Hardware higher than the construct's Size Category cannot be installed
        /// Drone: 0
        /// Dog-Size: 1
        /// Human-Size: 2
        /// One-Story: 3
        /// X-Story: X+2
        /// </summary>
        public int SizeCategory { get; set; }

        /// <summary>
        /// How difficult is it to hack into its operating system?
        /// Open-Source: None/Lowest
        /// Arch-Seal: Highest
        /// </summary>
        public int CyberGrade {  get; set; }

        /// <summary>
        /// How advanced is the construct's code?
        /// Certain upgrades only work with higher software grades
        /// SoftwareGrade is a sum of construct's Skill Levels
        /// </summary>
        public int SoftwareGrade {  get; set; }
        
        /// <summary>
        /// Base Attack Stat (Kinetic and Energy)
        /// </summary>
        public int Accuracy { get; set; }

        /// <summary>
        /// Base Resistance to Harm
        /// </summary>
        public int Armor {  get; set; }

        /// <summary>
        /// Base Speed to determine turn order
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Up to 4 functions that any construct can independently use
        /// </summary>
        /// -- TODO: Add milestones for naturally learning new functions
        /// -- TODO: Add modules to install new functions
        /// -- TODO: If programming a 5th function, give the option to cancel or
        ///          override an existing function.
        public virtual IList<BattleFunction>? BattleFunctions { get; set; }
    }
}
