using UnityEngine;

public class TileTypes : Base_Hexagon
{

    public bool normal = true;
    public int burn = 0;
    public int swamp = 0;
    public int raise = 0;
    public int draft = 0;
    public int refresh = 0;
    public int recant = 0;
    public int flash = 0;
    public int vivify = 0;

    public void update()
    {
        if (burn > 0)
        {
            Fire();
            normal = false;
        }

        else if (normal == true)
        {
            UnMark();
        }
    }

    public void Fire()
    {
        
    }

}
