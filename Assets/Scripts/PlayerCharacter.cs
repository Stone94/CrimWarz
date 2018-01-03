using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour 
{
	
	//TODO Create storage containers to increase max drugs held

	public static PlayerCharacter playChar; // Using Static References to decrease the amount of gameobjects i constantly need to link togethor.

	public float health; 
	public float cash;
	public float debtLeft; // The amount of debt the player has left
	public float ludesOwned;
	public float weedOwned;
	public float shroomOwned;
	public float LSDOwned;
	public float speedOwned;
	public float methOwned;
	public float cokeOwned;
	public float heroinOwned;
	public int hours;
	public int days;
	public float rep;
	public float bankBalance;
	public int potFarmOwned, shroomFarmOwned, hippieVanOwned, methLabOwned, pharmacyOwned;  // Variables for the Production Facilities
	public float drugMax;
	public float drugsOwned;
	public float maxFuel;
	public float currentFuel;
	public int maxGameDays;





	public float debtInterestRate; // This is here to serve as a global access for the same reason as using a static reference, less gameobjects linked togethor = happy me!

	void Awake () 
	{
		dontDestroyPlayerOnLoad ();

	}

	void Update ()
	{
		playerCaps ();
	}
	// if the player character exists, make it persist during scene changes, and destroy any duplicates keeping only the original.
	void dontDestroyPlayerOnLoad ()
	{
		if (playChar == null) {
			DontDestroyOnLoad (gameObject);
			playChar = this;
		}
		else
			if (playChar != this) {
				Destroy (gameObject);
			}
	}
		
	void playerCaps ()
	{
		if (playChar.cash > 9999999999999999)
		{
			playChar.cash = 9999999999999999;
		}

		if (playChar.bankBalance > 9999999999999999)
		{
			playChar.bankBalance = 9999999999999999;
		}

		drugsOwned = ludesOwned + shroomOwned + weedOwned + LSDOwned + methOwned + speedOwned + heroinOwned + cokeOwned;
	}
		
	// write game data to a file; using the playChar. prefix ensures the saving of the current running game character and not the prefab.
	public void Save()
	{
		GameObject.FindObjectOfType<PlayerCharacter>();
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/Saves/playerInfo.dat");


		PlayerDataa data = new PlayerDataa ();
		data.bankBalance = playChar.bankBalance;
		data.health = playChar.health;
		data.cash = playChar.cash;
		data.debtLeft = playChar.debtLeft;
		data.ludesOwned = playChar.ludesOwned;
		data.weedOwned = playChar.weedOwned;
		data.shroomOwned = playChar.shroomOwned;
		data.LSDOwned = playChar.LSDOwned;
		data.speedOwned = playChar.speedOwned;
		data.methOwned = playChar.methOwned;
		data.cokeOwned = playChar.cokeOwned;
		data.heroinOwned = playChar.heroinOwned;
		data.hours = playChar.hours;
		data.days = playChar.days;
		data.rep = playChar.rep;
		data.methLabOwned = playChar.methLabOwned;
		data.hippieVanOwned = playChar.hippieVanOwned;
		data.potFarmOwned = playChar.potFarmOwned;
		data.pharmacyOwned = playChar.pharmacyOwned;
		data.shroomFarmOwned = playChar.shroomFarmOwned;
		data.drugMax = playChar.drugMax;
		data.maxFuel = playChar.maxFuel;
		data.currentFuel = playChar.currentFuel;

		Debug.Log ("Saving to: " + Application.persistentDataPath);
		bf.Serialize (file, data);
		file.Close ();
		Debug.Log (playChar.cash.ToString());

		Debug.Log (data.cash.ToString());
	}

	// read game data from a file; using the playChar. prefix ensures the loading of the previous running game character and not the prefab.
	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/Saves/playerInfo.dat")) 
		{
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/Saves/playerInfo.dat", FileMode.Open);
			PlayerDataa data = (PlayerDataa)bf.Deserialize (file);
			file.Close ();

			playChar.bankBalance = data.bankBalance;
			playChar.health = data.health;
			playChar.cash = data.cash;
			playChar.debtLeft = data.debtLeft;
			playChar.ludesOwned = data.ludesOwned;
			playChar.weedOwned = data.weedOwned;
			playChar.shroomOwned = data.shroomOwned;
			playChar.LSDOwned = data.LSDOwned;
			playChar.speedOwned = data.speedOwned;
			playChar.methOwned = data.methOwned;
			playChar.cokeOwned = data.cokeOwned;
			playChar.heroinOwned = data.heroinOwned;
			playChar.hours = data.hours;
			playChar.days = data.days;
			playChar.rep = data.rep;
			playChar.methLabOwned = data.methLabOwned;
			playChar.hippieVanOwned = data.hippieVanOwned;
			playChar.potFarmOwned = data.potFarmOwned;
			playChar.pharmacyOwned = data.pharmacyOwned;
			playChar.shroomFarmOwned = data.shroomFarmOwned;
			playChar.drugMax = data.drugMax;
			playChar.maxFuel = data.maxFuel;
			playChar.currentFuel = data.currentFuel;

			Debug.Log (playChar.cash.ToString());

			Debug.Log (data.cash.ToString());
		}
	}
}

// make the game data saveable
[Serializable]
class PlayerDataa
{
	public float health;
	public float bankBalance;
	public float cash;
	public float debtLeft;
	public float ludesOwned;
	public float weedOwned;
	public float shroomOwned;
	public float LSDOwned;
	public float speedOwned;
	public float methOwned;
	public float cokeOwned;
	public float heroinOwned;
	public int hours;
	public int days;
	public float rep;
	public int potFarmOwned, shroomFarmOwned, hippieVanOwned, methLabOwned, pharmacyOwned; 
	public float drugMax;
	public float maxFuel;
	public float currentFuel;
}