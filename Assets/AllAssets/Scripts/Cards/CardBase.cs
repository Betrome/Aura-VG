using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase
{
	//Card Variables
	public string id;
	public string name;
	public int lvl;
	public int ap;
	public int cost;
	public int power;
	public int owner;
	public int[] abilities;
	public string details;


	//Area of Effect
	public enum Area {Single, Ray, Area}
	public int range;
	public int size;
	public bool target;
	public Area area;


	//Elements
	public enum Element {Fire, Water, Wind, Earth, Light, Dark, Spirit, Time, None}
	public Element element1;
	public Element element2;


	//Card Type
	public enum Type {Black, White, Green, Equipment, Movement}
	public Type type;


	public string set;
	public enum Rarity {Common, Uncommon, Rare, Fabled}
	public Rarity rarity;



	//upgrading
	public bool upgraded = false;

	protected void UpgradeDelta()
	{
		if (this.upgraded == false && this.cost > 0)
		{
			this.cost /= 2;

			this.upgraded = true;
			this.name += " Δ";
		}
		else
			Debug.Log("Error: This card's cost cannot be lowered.");
	}

	protected void UpgradeTheta()
	{
		if (this.upgraded == false)
		{
			if (this.target == true)
			{
				this.range += 1;
			}
			else
			{
				this.size += 1;
			}

			this.upgraded = true;
			this.name += " Θ";
		}
	}

	protected void UpgradeSigma()
	{
		if (this.upgraded == false)
		{
			//add random ability based on card type.

			this.upgraded = true;
			this.name += " Σ";
		}
	}

	protected void UpgradeLambda()
	{
		if (this.upgraded == false && this.abilities != null)
		{
			for (int i = 0; i < this.abilities.Length; i++)
			{
				abilities[i] *= 2;
			}

			this.upgraded = true;
			this.name += " Λ";
		}
		else
			Debug.Log("Error: This card has no abilities.");
	}

	protected void UpgradeOmega()
	{
		if (this.upgraded == false && this.power > 0)
		{
			this.power += (this.power + 1) / 2;

			this.upgraded = true;
			this.name += " Ω";
		}
		else
			Debug.Log("Error: This card has no Power or cannot have its Power upgraded.");

	}



}
