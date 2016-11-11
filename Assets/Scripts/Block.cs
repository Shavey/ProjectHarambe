using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Block {

    //Block type enum list
    enum blockType { Floor, Bulkhead, Wall, Armor, Door }

    int hitpoints;
    Deployable deployable;
    LooseObject looseobject;

    int x { get; set; }
    int y { get; set; }

    bool isPassable = false;
    bool doesConduct = false;








    public int Hitpoints
    {
        get
        {
            return hitpoints;
        }

        set
        {
            hitpoints = value;
        }
    }
}

class Armor : Block
{
    enum materialType
    {
        Steel, Aluminum, Polymer, Titanium, Tungsten
    }

    bool isPassable = false;
}
