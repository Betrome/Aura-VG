using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match 
{
	public const int playerCount = 2;

	public List<Player> players = new List<Player> (playerCount);
	public int currentPlayerIndex;

	public Player CurrentPlayer
	{
		get 
		{
			return players [currentPlayerIndex];
		}
	}

	public Player OpponentPlayer
	{
		get
		{
			return players [1 - currentPlayerIndex];
		}
	}
	public Match()
	{
		for (int i = 0; i < playerCount; ++i)
		{
			players.Add (new Player(i));
		}
	}

}
