using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileTrigger : MonoBehaviour
{
    public TileTypes tileTypes;


    void OnTriggerEnter (Collider other)
    {
        if (tileTypes.burn > 0)
        {

        }
    }

    void OnTriggerExit (Collider other)
    {

    }

}



