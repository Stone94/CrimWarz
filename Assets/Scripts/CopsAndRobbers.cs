using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopsAndRobbers : MonoBehaviour 
{
	//TODO These later need to be switched to a turn based fighting system
	//TODO Need to set a delay to allow the player to read the event prompts
	//TODO Add more busted events FBI(Frozen bank etc)
	public AudioClip cop;
	public AudioClip robber;
	public GameObject BustedDisp, MuggedDisp;

	public float bribeLoss, muggedLoss;

	public bool isBusted = false, isMugged = false;


	private int muggedChance, bustedChance;
	public int muggedChanceMin, muggedChanceMax, bustedChanceMax, bustedChanceMin;

	public void Busted ()
	{
		// set the chance to get busted between a certain value;

		bustedChance = Random.Range (bustedChanceMin, bustedChanceMax);

		/* if the player gets busted, take a percentage of his cash, 
		 * all his drugs and increase his hours to simulate an arrest */

		//TODO drugs are not being effected by getting busted for some reason
		if (bustedChance >= 90)
		{
			isBusted = true;
			Debug.Log ("Your Busted");
			PlayerCharacter.playChar.cash *= bribeLoss;
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

		/* if the player gets mugged, take a percentage of his cash, 
		 * increase his hours to simulate a knockout */

		if (muggedChance >= 95) 
		{
			isMugged = true;
			Debug.Log ("Your Mugged");
			PlayerCharacter.playChar.cash *= muggedLoss;
			PlayerCharacter.playChar.health -= 10;
			MuggedDisp.SetActive (true);
			PlayerCharacter.playChar.hours += 6;
			AudioSource.PlayClipAtPoint (robber, transform.position);
		}
	}

}
