using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopsAndRobbers : MonoBehaviour 
{
	public AudioClip cop;
	public AudioClip robber;
	public GameObject BustedDisp, MuggedDisp;

	public bool isBusted = false, isMugged = false;


	private int muggedChance, bustedChance;
	public int muggedChanceMin, muggedChanceMax, bustedChanceMax, bustedChanceMin;

	public void Busted ()
	{
		bustedChance = Random.Range (bustedChanceMin, bustedChanceMax);

		if (bustedChance >= 90)
		{
			isBusted = true;
			Debug.Log ("Your Busted");
			PlayerCharacter.playChar.cash *= 0.95f;
			PlayerCharacter.playChar.weedOwned = 0;
			PlayerCharacter.playChar.shroomOwned = 0;
			PlayerCharacter.playChar.LSDOwned = 0;
			PlayerCharacter.playChar.speedOwned = 0;
			PlayerCharacter.playChar.methOwned = 0;
			PlayerCharacter.playChar.cokeOwned = 0;
			PlayerCharacter.playChar.heroinOwned = 0;
			BustedDisp.SetActive(true);
			PlayerCharacter.playChar.health -= 10;
			PlayerCharacter.playChar.hours += 4;
			AudioSource.PlayClipAtPoint (cop, transform.position);
		}
	}

	public void Mugged()
	{
		muggedChance = Random.Range (muggedChanceMin, muggedChanceMax);
		if (muggedChance >= 95) 
		{
			isMugged = true;
			Debug.Log ("Your Mugged");
			PlayerCharacter.playChar.cash *= 0.5f;
			PlayerCharacter.playChar.health -= 10;
			MuggedDisp.SetActive (true);
			PlayerCharacter.playChar.hours += 6;
			AudioSource.PlayClipAtPoint (robber, transform.position);
		}
	}

}
