using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyberOhm.Entities
{
    public enum ConstructType
    {
        Droid,
        Drone,
        Dreg
    }

    public enum ConstructClass
    {
        // Primarily for pre-generating new constructs
        Assault, // starts with an Attack function
        Defender, // starts with a Sunder function
        Scout, // starts with an Analysis function
        Support // starts with a Fortify function
    }

    public enum FunctionType
    {
        Attack, // reduce the target's HP
        Analysis, // collect information
        Fortify, // increase Armor or Skill Level
        Move, // TBD
        Sunder // reduce target Armor, Accuracy, Speed, or Skill Level
    }

    public enum DamageType
    {
        Kinetic, // anything like a bullet, spear, grapeshot, or fragmentation
        Electric, // tasers and other such incapacitating harm
        Explosion, // missiles, mines, exploding barrels; sonic and kinetic/plasma/electric damage
        Ion, // EMP or any other disruptive force; deadly against constructs, less so versus humans
        Plasma, // superheated matter; equivalent to fire
        Sonic // equivalent to thunder
    }

    public enum ArmorType
    {
        Ablative, // immune to fire/electric, weak to ion
        None, // immune to ion, weak to kinetic
        Plate, // resist kinetic, weak to electric
        Rubber // immune to electric/ion, weak to fire/kinetic
    }
}
