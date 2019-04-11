using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

	public int level {get; set;}
	public int curHp {get; set;}
	public int maxHp {get; set;}
	public int exp {get; set;}


	public readonly int index;
	public Player (int index)
	{
    	this.index = index;
  	}

}
