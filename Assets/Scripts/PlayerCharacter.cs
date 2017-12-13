using System.Collections;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCharacter : MonoBehaviour 
{
	public static PlayerCharacter playChar;

	public float health;
	public float cash;
	public float cryptoC;
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
	public int rep;
	public float bankBalance;

	void Awake () 
	{
		dontDestroyPlayerOnLoad ();
	}

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
		

	// write game data to a file
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

	// read game data from a file
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
	public float bankBalance;
	public float cash;
	public float cryptoC;
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
	public int rep;
}