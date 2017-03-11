using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Block {

    //Block type enum list
    enum blockType { Floor, Bulkhead, Wall, Armor, Door }

    public int hitpoints { get; set; }
    Deployable deployable;
    LooseObject looseobject;

    public int x { get; set; }  //Getter and setters for x,y position
    public int y { get; set; }

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
