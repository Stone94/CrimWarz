using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drugs : MonoBehaviour
{
	public static Drugs drugs;
	public BuyMenuDisp BMD;
	public Text eventText, pocketDisp, ludeAmountText, weedAmountText, shroomAmountText, LSDAmountText, 
	speedAmountText, methAmountText, cokeAmountText, heroinAmountText;

	public AudioClip kaChing;
	public GameObject pocketPanel;

	public Slider ludeSlide, weedSlide, shroomSlide, LSDSlide, speedSlide, methSlide, cokeSlide, heroinSlide;

	private float ludeAmount, weedAmount, shroomAmount, LSDAmount, speedAmount, methAmount, cokeAmount, heroinAmount;
	public float ludeMin, ludeMax, weedMin, weedMax, shroomMin, shroomMax, lsdMin, lsdMax, 
	speedMin, speedMax, methMin, methMax, cokeMin, cokeMax, heroinMin, heroinMax, pocketCost, pocketSize;

	public float eventLudeMin, eventLudeMax, eventWeedMin, eventWeedMax, eventShroomMin, eventShroomMax, eventLSDMin, eventLSDMax, 
	eventSpeedMin, eventSpeedMax, eventMethMin, eventMethMax, eventCokeMin, eventCokeMax, eventHeroinMin, eventHeroinMax, eventLowLudeMin, 
	eventLowLudeMax, eventLowWeedMin, eventLowWeedMax, eventLowShroomMin, eventLowShroomMax, eventLowLSDMin, eventLowLSDMax, 
	eventLowSpeedMin, eventLowSpeedMax, eventLowMethMin, eventLowMethMax, eventLowCokeMin, eventLowCokeMax, eventLowHeroinMin, eventLowHeroinMax;

	// Set the product prices upon entering the scene
	void Awake()
	{
		PriceEventHigher ();
		RandomizeProductPrices ();
	}

	// ensure the products get updated and the slider value changes.
	void Update()
	{
		updatePrices ();
//		PayBills ();
		SliderValue ();
		weedAmountText.text = weedSlide.value.ToString ();
		ludeAmountText.text = ludeSlide.value.ToString ();
		shroomAmountText.text = shroomSlide.value.ToString ();
		speedAmountText.text = speedSlide.value.ToString ();
		LSDAmountText.text = LSDSlide.value.ToString ();
		methAmountText.text = methSlide.value.ToString ();
		cokeAmountText.text = cokeSlide.value.ToString ();
		heroinAmountText.text = heroinSlide.value.ToString ();

	}

	void updatePrices ()
	{
		if (PlayerCharacter.playChar.hours == 12 || PlayerCharacter.playChar.hours == 0) {
			//adjust the costs of products
			RandomizeProductPrices ();
		}
	}

	// Set a random price between the minimum and maximum value everytime function is called.
	public void RandomizeProductPrices ()
	{
		BMD.ludesCost = Random.Range (Mathf.Round(ludeMin), Mathf.Round(ludeMax));
		BMD.weedCost = Random.Range (Mathf.Round(weedMin), Mathf.Round(weedMax));
		BMD.shroomCost = Random.Range (Mathf.Round(shroomMin), Mathf.Round(shroomMax));
		BMD.LSDCost = Random.Range (Mathf.Round(lsdMin), Mathf.Round(lsdMax));
		BMD.speedCost = Random.Range (Mathf.Round(speedMin), Mathf.Round(speedMax));
		BMD.methCost = Random.Range (Mathf.Round(methMin), Mathf.Round(methMax));
		BMD.cokeCost = Random.Range (Mathf.Round(cokeMin), Mathf.Round(cokeMax));
		BMD.heroinCost = Random.Range (Mathf.Round(heroinMin), Mathf.Round(heroinMax));
	}

	// The slider that sets the value of purchase 
	void SliderValue ()
	{
		ludeSlide.maxValue = PlayerCharacter.playChar.drugMax;
		weedSlide.maxValue = PlayerCharacter.playChar.drugMax;
		shroomSlide.maxValue = PlayerCharacter.playChar.drugMax;
		LSDSlide.maxValue = PlayerCharacter.playChar.drugMax;
		speedSlide.maxValue = PlayerCharacter.playChar.drugMax;
		methSlide.maxValue = PlayerCharacter.playChar.drugMax;
		cokeSlide.maxValue = PlayerCharacter.playChar.drugMax;
		heroinSlide.maxValue = PlayerCharacter.playChar.drugMax;

		ludeAmount = ludeSlide.value;
		weedAmount = weedSlide.value;
		shroomAmount = shroomSlide.value;
		LSDAmount = LSDSlide.value;
		speedAmount = speedSlide.value;
		methAmount = methSlide.value;
		cokeAmount = cokeSlide.value;
		heroinAmount = heroinSlide.value;
	}




	/* THIS IS YET TO BE IMPLEMENTED
	void PayBills ()
	{
		if (PlayerCharacter.playChar.days % 14 == 0) {
			if (PlayerCharacter.playChar.hours == 12) {
				PlayerCharacter.playChar.cash -= 1000;
				eventText.text = "You had to pay your bills, $1000 has been removed from your wallet";
			}
		}
	}
*/

	private int lowerChance, PriceRaiseChance;

	public int lowerChanceMin, lowerChanceMax, higherChanceMax, higherChanceMin;
	private int eventChance;

	public void PriceEventHigher ()
	{
		// set the chance for prices to skyrocket;

		PriceRaiseChance = Random.Range (higherChanceMin, higherChanceMax);
		lowerChance = Random.Range (lowerChanceMin, lowerChanceMax); 
		eventChance = Random.Range (higherChanceMin, higherChanceMax);

		if (PriceRaiseChance == eventChance) {
			eventChance = Random.Range (1, 20);
			//TODO Make more flavorful text for these events
			if (eventChance == 1) {
				weedMin = eventWeedMin;
				weedMax = eventWeedMax;
				eventText.text = "There was a drug raid recently and weed prices have sky rocketed!";
				Debug.Log (PriceRaiseChance);

			} else if (eventChance == 2) {
				lsdMin = eventLSDMin;
				lsdMax = eventLSDMax;
				eventText.text = "There was a drug raid recently and LSD prices have sky rocketed!";

			} else if (eventChance == 3) {
				shroomMin = eventShroomMin;
				shroomMax = eventShroomMax;
				eventText.text = "There was a drug raid recently and shroom prices have sky rocketed!";

			} else if (eventChance == 4) {
				speedMin = eventSpeedMin;
				speedMax = eventSpeedMax;
				eventText.text = "There was a drug raid recently and speed prices have sky rocketed!";

			} else if (eventChance == 5) {
				methMin = eventMethMin;
				methMax = eventMethMax;
				eventText.text = "There was a drug raid recently and meth prices have sky rocketed!";

			} else if (eventChance == 6) {
				heroinMin = eventHeroinMin;
				heroinMax = eventHeroinMax;
				eventText.text = "There was a drug raid recently and heroin prices have sky rocketed!";

			} else if (eventChance == 7) {
				ludeMin = eventLudeMin;
				ludeMax = eventLudeMax;
				eventText.text = "There was a drug raid recently and lude prices have sky rocketed!";

			} else if (eventChance == 8) {
				cokeMin = eventCokeMin;
				cokeMax = eventCokeMax;
				eventText.text = "There was a drug raid recently and coke prices have sky rocketed!";

			} else if (eventChance >=9) {
				pocketCost = Random.Range (50, 100);
				pocketSize = Random.Range (9, 20);
				pocketDisp.text = "Would you like to buy " + pocketSize + " more pockets for: $" + (pocketSize * pocketCost);
				pocketPanel.SetActive (true);
			}
		}

		if (lowerChance == eventChance) {
			eventChance = Random.Range (1, 9);

			if (eventChance == 1) {
				weedMin = eventLowWeedMin;
				weedMax = eventLowWeedMax;
				eventText.text = "Your supplier had a bountiful harvest today, Weed prices have bottomed out!";
			} else if (eventChance == 2) {
				lsdMin = eventLowLSDMin;
				lsdMax = eventLowLSDMax;
				eventText.text = "Some hippies released how to make home made LSD prices have tanked!";

			} else if (eventChance == 3) {
				shroomMin = eventLowShroomMin;
				shroomMax = eventLowShroomMax;
				eventText.text = "A Farmer flooded the market with cheap shrooms, and prices have plummeted!";

			} else if (eventChance == 4) {
				speedMin = eventLowSpeedMin;
				speedMax = eventLowSpeedMax;
				eventText.text = "A group of dutch bikers came with loads of speed and prices have never been lower!";

			} else if (eventChance == 5) {
				methMin = eventLowMethMin;
				methMax = eventLowMethMax;
				eventText.text = "Some guy called Heisenburger started cooking the best meth ever, Market prices have fallen as a result!";

			} else if (eventChance == 6) {
				heroinMin = eventLowHeroinMin;
				heroinMax = eventLowHeroinMax;
				eventText.text = "The Cartel came in with a freight load of Heroin and prices have sunk!";

			} else if (eventChance == 7) {
				ludeMin = eventLowLudeMin;
				ludeMax = eventLowLudeMax;
				eventText.text = "Doctors are giving ludes out like its christmas and lude prices are insanely low!";

			} else if (eventChance == 8) {
				cokeMin = eventLowCokeMin;
				cokeMax = eventLowCokeMax;
				eventText.text = "Tony Banana flooded the market with cheap coke, prices are incredible right now!";

			} else if (eventChance >=9) {
				pocketCost = Random.Range (50, 100);
				pocketSize = Random.Range (9, 20);
				pocketDisp.text = "Would you like to buy " + pocketSize + " more pockets for: $" + (pocketSize * pocketCost);
				pocketPanel.SetActive (true);
			}
		}
	}

	// Functions for buying and selling drugs, currently WIP and need to make them more efficient as scale increases.
	//TODO make this more efficient somehow (LESS functions, MORE reusability)
	//TODO Set these to OnPointerDown to improve response times on android

	public void buyPockets()
	{
		if (PlayerCharacter.playChar.cash >= pocketCost * pocketSize) 
		{
			PlayerCharacter.playChar.drugMax += pocketSize;
			PlayerCharacter.playChar.cash -= pocketCost * pocketSize;
			pocketPanel.SetActive (false);
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void buyLude()
	{
		if (PlayerCharacter.playChar.cash >= BMD.ludesCost * ludeAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + ludeAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.ludesOwned += ludeAmount;
			PlayerCharacter.playChar.cash -= BMD.ludesCost * ludeAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));

		} 
	}

	public void sellLude()
	{
		if (PlayerCharacter.playChar.ludesOwned >= ludeAmount) 
		{
			PlayerCharacter.playChar.ludesOwned -= ludeAmount;
			PlayerCharacter.playChar.cash += BMD.ludesCost * ludeAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void buyWeed()
	{
		if (PlayerCharacter.playChar.cash >= BMD.weedCost * weedAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + weedAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.weedOwned += weedAmount;
			PlayerCharacter.playChar.cash -= BMD.weedCost * weedAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void sellWeed()
	{
		if (PlayerCharacter.playChar.weedOwned >= weedAmount) 
		{
			PlayerCharacter.playChar.weedOwned -= weedAmount;
			PlayerCharacter.playChar.cash += BMD.weedCost * weedAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}
		

	public void buyShrooms()
	{
		if (PlayerCharacter.playChar.cash >= BMD.shroomCost * shroomAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + shroomAmount <=PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.shroomOwned += shroomAmount;
			PlayerCharacter.playChar.cash -= BMD.shroomCost * shroomAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void sellShroom()
	{
		if (PlayerCharacter.playChar.shroomOwned >= shroomAmount) 
		{
			PlayerCharacter.playChar.shroomOwned -= shroomAmount;
			PlayerCharacter.playChar.cash += BMD.shroomCost * shroomAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void buyLSD()
	{
		if (PlayerCharacter.playChar.cash >= BMD.LSDCost * LSDAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + LSDAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.LSDOwned += LSDAmount;
			PlayerCharacter.playChar.cash -= BMD.LSDCost * LSDAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void sellLSD()
	{
		if (PlayerCharacter.playChar.LSDOwned >= LSDAmount) 
		{
			PlayerCharacter.playChar.LSDOwned -= LSDAmount;
			PlayerCharacter.playChar.cash += BMD.LSDCost * LSDAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void buySpeed()
	{
		if (PlayerCharacter.playChar.cash >= BMD.speedCost * speedAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + speedAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.speedOwned += speedAmount;
			PlayerCharacter.playChar.cash -= BMD.speedCost * speedAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void sellSpeed()
	{
		if (PlayerCharacter.playChar.speedOwned >= speedAmount) 
		{
			PlayerCharacter.playChar.speedOwned -= speedAmount;
			PlayerCharacter.playChar.cash += BMD.speedCost * speedAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void buyMeth()
	{
		if (PlayerCharacter.playChar.cash >= BMD.methCost * methAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + methAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.methOwned += methAmount;
			PlayerCharacter.playChar.cash -= BMD.methCost * methAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void sellMeth()
	{
		if (PlayerCharacter.playChar.methOwned >= methAmount) 
		{
			PlayerCharacter.playChar.methOwned -= methAmount;
			PlayerCharacter.playChar.cash += BMD.methCost * methAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void buyCoke()
	{
		if (PlayerCharacter.playChar.cash >= BMD.cokeCost * cokeAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + cokeAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.cokeOwned += cokeAmount;
			PlayerCharacter.playChar.cash -= BMD.cokeCost * cokeAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void sellCoke()
	{
		if (PlayerCharacter.playChar.cokeOwned >= cokeAmount) 
		{
			PlayerCharacter.playChar.cokeOwned -= cokeAmount;
			PlayerCharacter.playChar.cash += BMD.cokeCost * cokeAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}

	public void buyHeroin()
	{
		if (PlayerCharacter.playChar.cash >= BMD.heroinCost * heroinAmount && PlayerCharacter.playChar.drugsOwned < PlayerCharacter.playChar.drugMax 
			&& PlayerCharacter.playChar.drugsOwned + heroinAmount <= PlayerCharacter.playChar.drugMax) 
		{
			PlayerCharacter.playChar.heroinOwned += heroinAmount;
			PlayerCharacter.playChar.cash -= BMD.heroinCost * heroinAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		} 
	}

	public void sellHeroin()
	{
		if (PlayerCharacter.playChar.heroinOwned >= heroinAmount) 
		{
			PlayerCharacter.playChar.heroinOwned -= heroinAmount;
			PlayerCharacter.playChar.cash += BMD.heroinCost * heroinAmount;
			AudioSource.PlayClipAtPoint (kaChing, new Vector3(0,0,-10));
		}
	}
}
	
