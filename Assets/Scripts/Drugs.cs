using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Drugs : MonoBehaviour{

	public GameManager GM;
	public PlayerCharacter PC;
	public Slider amountSlider;
	public Text amountSliderText;

	private float amount;


	void Awake()
	{
		randomizeProductPrices ();
		PC = GameObject.FindObjectOfType<PlayerCharacter>();
	}
	void Update()
	{
		updateProductPrices ();
		setAmountSliderValue ();
	}

	void updateProductPrices ()
	{
		if (PC.hours == 12 || PC.hours == 23) {
			//adjust the costs of products
			randomizeProductPrices ();
		}
	}

	public void randomizeProductPrices ()
	{
		GM.ludesCost = UnityEngine.Random.Range (Mathf.Round(10.0f), Mathf.Round(40.0f));
		GM.weedCost = UnityEngine.Random.Range (Mathf.Round(100.0f), Mathf.Round(250.0f));
		GM.shroomCost = UnityEngine.Random.Range (Mathf.Round(350.0f), Mathf.Round(450.0f));
		GM.LSDCost = UnityEngine.Random.Range (Mathf.Round(500.0f), Mathf.Round(1050.0f));
		GM.speedCost = UnityEngine.Random.Range (Mathf.Round(1200.0f), Mathf.Round(5000.0f));
		GM.methCost = UnityEngine.Random.Range (Mathf.Round(4500.0f), Mathf.Round(12000.0f));
		GM.cokeCost = UnityEngine.Random.Range (Mathf.Round(10000.0f), Mathf.Round(30000.0f));
		GM.heroinCost = UnityEngine.Random.Range (Mathf.Round(11000.0f), Mathf.Round(50500.0f));
	}

	void setAmountSliderValue ()
	{
		amountSliderText.text = "Amount: " + amountSlider.value.ToString ();
		amount = amountSlider.value;
	}
		
	public void buyLude(){
		if (PC.cash >= GM.ludesCost * amount) {
			PC.ludesOwned += amount;
			PC.cash -= GM.ludesCost * amount;

		} 
	}

	public void sellLude(){
		if (PC.ludesOwned >= amount) {
			PC.ludesOwned -= amount;
			PC.cash += GM.ludesCost * amount;
		}
	}

	public void buyWeed(){
		if (PC.cash >= GM.weedCost * amount) {
			PC.weedOwned += amount;
			PC.cash -= GM.weedCost * amount;
		} 
	}

	public void sellWeed(){
		if (PC.weedOwned >= amount) {
			PC.weedOwned -= amount;
			PC.cash += GM.weedCost * amount;
		}
	}
		

	public void buyShrooms(){
		if (PC.cash >= GM.shroomCost * amount) {
			PC.shroomOwned += amount;
			PC.cash -= GM.shroomCost * amount;
		} 
	}

	public void sellShroom(){
		if (PC.shroomOwned >= amount) {
			PC.shroomOwned -= amount;
			PC.cash += GM.shroomCost * amount;
		}
	}

	public void buyLSD(){
		if (PC.cash >= GM.LSDCost * amount) {
			PC.LSDOwned += amount;
			PC.cash -= GM.LSDCost * amount;
		}
	}

	public void sellLSD(){
		if (PC.LSDOwned >= amount) {
			PC.LSDOwned -= amount;
			PC.cash += GM.LSDCost * amount;
		}
	}

	public void buySpeed(){
		if (PC.cash >= GM.speedCost * amount) {
			PC.speedOwned += amount;
			PC.cash -= GM.speedCost * amount;
		} 
	}

	public void sellSpeed(){
		if (PC.speedOwned >= amount) {
			PC.speedOwned -= amount;
			PC.cash += GM.speedCost * amount;
		}
	}

	public void buyMeth(){
		if (PC.cash >= GM.methCost * amount) {
			PC.methOwned += amount;
			PC.cash -= GM.methCost * amount;
		} 
	}

	public void sellMeth(){
		if (PC.methOwned >= amount) {
			PC.methOwned -= amount;
			PC.cash += GM.methCost * amount;
		}
	}

	public void buyCoke(){
		if (PC.cash >= GM.cokeCost * amount) {
			PC.cokeOwned += amount;
			PC.cash -= GM.cokeCost * amount;
		} 
	}

	public void sellCoke(){
		if (PC.cokeOwned >= amount) {
			PC.cokeOwned -= amount;
			PC.cash += GM.cokeCost * amount;
		}
	}

	public void buyHeroin(){
		if (PC.cash >= GM.heroinCost * amount) {
			PC.heroinOwned += amount;
			PC.cash -= GM.heroinCost * amount;
		} 
	}

	public void sellHeroin(){
		if (PC.heroinOwned >= amount) {
			PC.heroinOwned -= amount;
			PC.cash += GM.heroinCost * amount;
		}
	}
}
	
