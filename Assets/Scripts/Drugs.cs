using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/* TODO Fine the bug thats preventing the amount slider from setting the value. */
public class Drugs : MonoBehaviour
{

	public BuyMenuDisp BMD;

	// Purchase Amount Slider
	public Slider amountSlider;
	public Text amountSliderText;

	private float amount;
	public float ludeMin, ludeMax, weedMin, weedMax, shroomMin, shroomMax, lsdMin, lsdMax, speedMin, speedMax, methMin, methMax, cokeMin, cokeMax, heroinMin, heroinMax;

	// Set the product prices upon entering the scene
	void Awake()
	{
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

	// The slider that sets the value of purchase TODO add a +-1 button for fine incrementing
	void AmountSlideValue ()
	{
		amountSliderText.text = "Amount: " + amountSlider.value.ToString ();
		amount = amountSlider.value;
	}




	// Functions for buying and selling drugs, currently WIP and need to make them more efficient as scale increases.
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
	
