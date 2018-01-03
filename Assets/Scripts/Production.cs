using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Production : MonoBehaviour {

	public static Production production;

	public Text potFarmDisp, shroomFarmProduceDisp, hippieVanDisp, methLabDisp, pharmacyDisp;

	public float potFarmCost, shroomFarmCost, hippieVanCost, methLabCost, pharmacyCost;

	void Update()
	{
		potFarmDisp.text ="Pot Farm\t" + "Cost: $" + potFarmCost.ToString () + "    Owned: " + PlayerCharacter.playChar.potFarmOwned.ToString () + "    P/Per/W: " + (10 * PlayerCharacter.playChar.potFarmOwned * 10).ToString ();
		shroomFarmProduceDisp.text = "Shroom Farm\t\t" + "Cost: $" + shroomFarmCost.ToString () + "    Owned: " + PlayerCharacter.playChar.shroomFarmOwned.ToString () + "    P/Per/W: " + (10 * PlayerCharacter.playChar.shroomFarmOwned * 10).ToString ();
		hippieVanDisp.text = "Hippie Van\t\t" + "Cost: $" + hippieVanCost.ToString () + "    Owned: " + PlayerCharacter.playChar.hippieVanOwned.ToString () + "    P/Per/W: " + (10 * PlayerCharacter.playChar.hippieVanOwned * 10).ToString ();
		methLabDisp.text = "Meth Lab\t\t" + "Cost: $" + methLabCost.ToString () + "    Owned: " + PlayerCharacter.playChar.methLabOwned.ToString () + "    P/Per/W: " + (10 * PlayerCharacter.playChar.methLabOwned * 10).ToString ();
		pharmacyDisp.text = "Pharmacy\t\t" + "Cost: $" + pharmacyCost.ToString () + "    Owned: " + PlayerCharacter.playChar.pharmacyOwned.ToString () + "    P/Per/W: " + (10 * PlayerCharacter.playChar.pharmacyOwned * 10).ToString ();
	}

	public void BuyPotFarm()
	{
		if (PlayerCharacter.playChar.cash >= potFarmCost)
		{
			PlayerCharacter.playChar.cash -= potFarmCost;
			PlayerCharacter.playChar.potFarmOwned++;
			PlayerCharacter.playChar.drugMax += 100;
		}
	}
	public void BuyShroomFarm()
	{
		if (PlayerCharacter.playChar.cash >= shroomFarmCost)
		{
			PlayerCharacter.playChar.cash -= shroomFarmCost;
			PlayerCharacter.playChar.shroomFarmOwned++;
			PlayerCharacter.playChar.drugMax += 100;
		}
	}
	public void BuyHippieVan()
	{
		if (PlayerCharacter.playChar.cash >= hippieVanCost)
		{
			PlayerCharacter.playChar.cash -= hippieVanCost;
			PlayerCharacter.playChar.hippieVanOwned++;
			PlayerCharacter.playChar.drugMax += 100;
		}
	}
	public void BuyMethLab()
	{
		if (PlayerCharacter.playChar.cash >= methLabCost)
		{
			PlayerCharacter.playChar.cash -= methLabCost;
			PlayerCharacter.playChar.methLabOwned++;
			PlayerCharacter.playChar.drugMax += 100;
		}
	}
	public void BuyPharmacy()
	{
		if (PlayerCharacter.playChar.cash >= pharmacyCost)
		{
			PlayerCharacter.playChar.cash -= pharmacyCost;
			PlayerCharacter.playChar.pharmacyOwned++;
			PlayerCharacter.playChar.drugMax += 100;
		}
	}
}
