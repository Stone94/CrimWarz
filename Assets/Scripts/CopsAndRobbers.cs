using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopsAndRobbers : MonoBehaviour 
{
	public PlayerCharacter PC;
	public GameObject BustedDisp, MuggedDisp;

	public bool isBusted = false, isMugged = false;


	private int muggedChance, bustedChance;
	public int muggedChanceMin, muggedChanceMax, bustedChanceMax, bustedChanceMin;

	void Update()
	{
		PC = GameObject.FindObjectOfType<PlayerCharacter>();
	}

	public void Busted ()
	{
		bustedChance = Random.Range (bustedChanceMin, bustedChanceMax);

		if (bustedChance >= 90)
		{
			isBusted = true;
			Debug.Log ("Your Busted");
			PC.cash *= 0.95f;
			PC.weedOwned = 0;
			PC.shroomOwned = 0;
			PC.LSDOwned = 0;
			PC.speedOwned = 0;
			PC.methOwned = 0;
			PC.cokeOwned = 0;
			PC.heroinOwned = 0;
			BustedDisp.SetActive(true);
			PC.health -= 10;
			PC.hours += 4;
		}
	}

	public void Mugged()
	{
		muggedChance = Random.Range (muggedChanceMin, muggedChanceMax);
		if (muggedChance >= 95) 
		{
			isMugged = true;
			Debug.Log ("Your Mugged");
			PC.cash *= 0.5f;
			PC.health -= 10;
			MuggedDisp.SetActive (true);
			PC.hours += 6;
		}
	}

}
