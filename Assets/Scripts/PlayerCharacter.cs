using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour 
{
	//TODO Set a limit on how many drugs can be held
	//TODO Create storage containers to increase max drugs held

	public static PlayerCharacter playChar; // Using Static References to decrease the amount of gameobjects i constantly need to link togethor.

	public float health; 
	public double cash;
	public double cryptoC; // Feature yet to be implemented
	public double debtLeft; // The amount of debt the player has left
	public double ludesOwned;
	public double weedOwned;
	public double shroomOwned;
	public double LSDOwned;
	public double speedOwned;
	public double methOwned;
	public double cokeOwned;
	public double heroinOwned;
	public int hours;
	public int days;
	public double rep;
	public double bankBalance;
	public int potFarmOwned, shroomFarmOwned;







	public double debtInterestRate; // This is here to serve as a global access for the same reason as using a static reference, less gameobjects linked togethor = happy me!

	void Awake () 
	{
		dontDestroyPlayerOnLoad ();
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
		data.cryptoC = playChar.cryptoC;
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
			playChar.cryptoC = data.cryptoC;
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
	public double bankBalance;
	public double cash;
	public double cryptoC;
	public double debtLeft;
	public double ludesOwned;
	public double weedOwned;
	public double shroomOwned;
	public double LSDOwned;
	public double speedOwned;
	public double methOwned;
	public double cokeOwned;
	public double heroinOwned;
	public int hours;
	public int days;
	public double rep;
}