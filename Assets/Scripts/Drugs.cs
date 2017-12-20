using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* TODO Fine the bug thats preventing the amount slider from setting the value. */
public class Drugs : MonoBehaviour
{
	public static Drugs drugs;
	public BuyMenuDisp BMD;
	public Text eventText;


	// Purchase Amount Slider
	public Slider amountSlider;
	public Text amountSliderText;

	private float amount;
	public float ludeMin, ludeMax, weedMin, weedMax, shroomMin, shroomMax, lsdMin, lsdMax, 
	speedMin, speedMax, methMin, methMax, cokeMin, cokeMax, heroinMin, heroinMax;

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
		AmountSlideValue ();
		updatePrices ();
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
	//TODO add a +-1 buttons for fine incrementing
	void AmountSlideValue ()
	{
		amountSliderText.text = "Amount: " + amountSlider.value.ToString ();
		amount = amountSlider.value;
	}
	public void AmountSlideValuePlusOne ()
	{
		amountSlider.value +=1;
	}
	public void AmountSlideValueMinusOne ()
	{
		amountSlider.value-=1;
	}

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
			eventChance = Random.Range (1, 8);
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

			}
		}

		if (lowerChance == eventChance) {
			eventChance = Random.Range (1, 8);

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
			}
		}
	}

	// Functions for buying and selling drugs, currently WIP and need to make them more efficient as scale increases.
	//TODO make this more efficient somehow (LESS functions, MORE reusability)
	//TODO Set these to OnPointerDown to improve response times on android
	public void buyLude()
	{
		if (PlayerCharacter.playChar.cash >= BMD.ludesCost * amount) 
		{
			PlayerCharacter.playChar.ludesOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.ludesCost * amount;

		} 
	}

	public void sellLude()
	{
		if (PlayerCharacter.playChar.ludesOwned >= amount) 
		{
			PlayerCharacter.playChar.ludesOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.ludesCost * amount;
		}
	}

	public void buyWeed()
	{
		if (PlayerCharacter.playChar.cash >= BMD.weedCost * amount) 
		{
			PlayerCharacter.playChar.weedOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.weedCost * amount;
		} 
	}

	public void sellWeed()
	{
		if (PlayerCharacter.playChar.weedOwned >= amount) 
		{
			PlayerCharacter.playChar.weedOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.weedCost * amount;
		}
	}
		

	public void buyShrooms()
	{
		if (PlayerCharacter.playChar.cash >= BMD.shroomCost * amount) 
		{
			PlayerCharacter.playChar.shroomOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.shroomCost * amount;
		} 
	}

	public void sellShroom()
	{
		if (PlayerCharacter.playChar.shroomOwned >= amount) 
		{
			PlayerCharacter.playChar.shroomOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.shroomCost * amount;
		}
	}

	public void buyLSD()
	{
		if (PlayerCharacter.playChar.cash >= BMD.LSDCost * amount) 
		{
			PlayerCharacter.playChar.LSDOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.LSDCost * amount;
		}
	}

	public void sellLSD()
	{
		if (PlayerCharacter.playChar.LSDOwned >= amount) 
		{
			PlayerCharacter.playChar.LSDOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.LSDCost * amount;
		}
	}

	public void buySpeed()
	{
		if (PlayerCharacter.playChar.cash >= BMD.speedCost * amount) 
		{
			PlayerCharacter.playChar.speedOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.speedCost * amount;
		} 
	}

	public void sellSpeed()
	{
		if (PlayerCharacter.playChar.speedOwned >= amount) 
		{
			PlayerCharacter.playChar.speedOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.speedCost * amount;
		}
	}

	public void buyMeth()
	{
		if (PlayerCharacter.playChar.cash >= BMD.methCost * amount) 
		{
			PlayerCharacter.playChar.methOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.methCost * amount;
		} 
	}

	public void sellMeth()
	{
		if (PlayerCharacter.playChar.methOwned >= amount) 
		{
			PlayerCharacter.playChar.methOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.methCost * amount;
		}
	}

	public void buyCoke()
	{
		if (PlayerCharacter.playChar.cash >= BMD.cokeCost * amount) 
		{
			PlayerCharacter.playChar.cokeOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.cokeCost * amount;
		} 
	}

	public void sellCoke()
	{
		if (PlayerCharacter.playChar.cokeOwned >= amount) 
		{
			PlayerCharacter.playChar.cokeOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.cokeCost * amount;
		}
	}

	public void buyHeroin()
	{
		if (PlayerCharacter.playChar.cash >= BMD.heroinCost * amount) 
		{
			PlayerCharacter.playChar.heroinOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.heroinCost * amount;
		} 
	}

	public void sellHeroin()
	{
		if (PlayerCharacter.playChar.heroinOwned >= amount) 
		{
			PlayerCharacter.playChar.heroinOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.heroinCost * amount;
		}
	}
}
	
