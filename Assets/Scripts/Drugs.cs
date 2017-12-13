using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drugs : MonoBehaviour{

	public BuyMenuDisp BMD;
	public Slider amountSlider;
	public Text amountSliderText;

	private float amount;


	void Awake()
	{
		updateProductPrices ();
	}
	void Update()
	{
		updateProductPrices ();
		setAmountSliderValue ();
	}

	void updateProductPrices ()
	{
		if (PlayerCharacter.playChar.hours == 12 || PlayerCharacter.playChar.hours == 0) {
			//adjust the costs of products
			randomizeProductPrices ();
		}
	}

	public void randomizeProductPrices ()
	{
		BMD.ludesCost = Random.Range (Mathf.Round(10.0f), Mathf.Round(40.0f));
		BMD.weedCost = Random.Range (Mathf.Round(100.0f), Mathf.Round(250.0f));
		BMD.shroomCost = Random.Range (Mathf.Round(350.0f), Mathf.Round(450.0f));
		BMD.LSDCost = Random.Range (Mathf.Round(500.0f), Mathf.Round(1050.0f));
		BMD.speedCost = Random.Range (Mathf.Round(1200.0f), Mathf.Round(5000.0f));
		BMD.methCost = Random.Range (Mathf.Round(4500.0f), Mathf.Round(12000.0f));
		BMD.cokeCost = Random.Range (Mathf.Round(10000.0f), Mathf.Round(30000.0f));
		BMD.heroinCost = Random.Range (Mathf.Round(11000.0f), Mathf.Round(50500.0f));
	}

	void setAmountSliderValue ()
	{
		amountSliderText.text = "Amount: " + amountSlider.value.ToString ();
		amount = amountSlider.value;
	}
		
	public void buyLude(){
		if (PlayerCharacter.playChar.cash >= BMD.ludesCost * amount) {
			PlayerCharacter.playChar.ludesOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.ludesCost * amount;

		} 
	}

	public void sellLude(){
		if (PlayerCharacter.playChar.ludesOwned >= amount) {
			PlayerCharacter.playChar.ludesOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.ludesCost * amount;
		}
	}

	public void buyWeed(){
		if (PlayerCharacter.playChar.cash >= BMD.weedCost * amount) {
			PlayerCharacter.playChar.weedOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.weedCost * amount;
		} 
	}

	public void sellWeed(){
		if (PlayerCharacter.playChar.weedOwned >= amount) {
			PlayerCharacter.playChar.weedOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.weedCost * amount;
		}
	}
		

	public void buyShrooms(){
		if (PlayerCharacter.playChar.cash >= BMD.shroomCost * amount) {
			PlayerCharacter.playChar.shroomOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.shroomCost * amount;
		} 
	}

	public void sellShroom(){
		if (PlayerCharacter.playChar.shroomOwned >= amount) {
			PlayerCharacter.playChar.shroomOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.shroomCost * amount;
		}
	}

	public void buyLSD(){
		if (PlayerCharacter.playChar.cash >= BMD.LSDCost * amount) {
			PlayerCharacter.playChar.LSDOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.LSDCost * amount;
		}
	}

	public void sellLSD(){
		if (PlayerCharacter.playChar.LSDOwned >= amount) {
			PlayerCharacter.playChar.LSDOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.LSDCost * amount;
		}
	}

	public void buySpeed(){
		if (PlayerCharacter.playChar.cash >= BMD.speedCost * amount) {
			PlayerCharacter.playChar.speedOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.speedCost * amount;
		} 
	}

	public void sellSpeed(){
		if (PlayerCharacter.playChar.speedOwned >= amount) {
			PlayerCharacter.playChar.speedOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.speedCost * amount;
		}
	}

	public void buyMeth(){
		if (PlayerCharacter.playChar.cash >= BMD.methCost * amount) {
			PlayerCharacter.playChar.methOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.methCost * amount;
		} 
	}

	public void sellMeth(){
		if (PlayerCharacter.playChar.methOwned >= amount) {
			PlayerCharacter.playChar.methOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.methCost * amount;
		}
	}

	public void buyCoke(){
		if (PlayerCharacter.playChar.cash >= BMD.cokeCost * amount) {
			PlayerCharacter.playChar.cokeOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.cokeCost * amount;
		} 
	}

	public void sellCoke(){
		if (PlayerCharacter.playChar.cokeOwned >= amount) {
			PlayerCharacter.playChar.cokeOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.cokeCost * amount;
		}
	}

	public void buyHeroin(){
		if (PlayerCharacter.playChar.cash >= BMD.heroinCost * amount) {
			PlayerCharacter.playChar.heroinOwned += amount;
			PlayerCharacter.playChar.cash -= BMD.heroinCost * amount;
		} 
	}

	public void sellHeroin(){
		if (PlayerCharacter.playChar.heroinOwned >= amount) {
			PlayerCharacter.playChar.heroinOwned -= amount;
			PlayerCharacter.playChar.cash += BMD.heroinCost * amount;
		}
	}
}
	
