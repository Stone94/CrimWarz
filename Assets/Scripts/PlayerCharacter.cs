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

	public GameManager GM;

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
		Environment.SetEnvironmentVariable("MONO_REFLECTION_SERIALIZER", "yes");
		GM = GameObject.FindObjectOfType<GameManager>();
		// Make sure only one player character object exists, create it if it doesnt
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

	void Start ()
	{
		StartCoroutine (time ());
	}

	// Update is called once per frame
	void Update () 
	{
		gameOverDebt (); 
		gameOverDeath ();
	}
		


	// creates the timer
	private void timeAdd()
	{
		hours += 1;

		if (hours >= 24) 
		{
			days += 1;
			hours = 0;
			debtLeft *= 1.10f;
			bankBalance = (bankBalance + rep) * 1.12f;
			rep += 1;
		}
	}



	// sets the debt related lose condition
	public void gameOverDebt()
	{
		if (debtLeft >= 20000f || days >= 30 && debtLeft >= 1f)
			SceneManager.LoadScene("01d Lose");
	}

	public void gameOverDeath()
	{
		if (health <= 0) 
		{
			SceneManager.LoadScene ("01d Lose 1");
		}

	}
	// while time remains true wait one second then add time
	IEnumerator time()
	{
		while (true) 
		{
			timeAdd ();
			yield return new WaitForSeconds (2);
		}
	}




	// write game data to a file
	public void Save()
	{
		GameObject.FindObjectOfType<PlayerCharacter>();
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/Saves/playerInfo.dat");


		PlayerDataa data = new PlayerDataa ();
		data.bankBalance = bankBalance;
		data.health = health;
		data.cash = cash;
		data.cryptoC = cryptoC;
		data.debtLeft = debtLeft;
		data.ludesOwned = ludesOwned;
		data.weedOwned = weedOwned;
		data.shroomOwned = shroomOwned;
		data.LSDOwned = LSDOwned;
		data.speedOwned = speedOwned;
		data.methOwned = methOwned;
		data.cokeOwned = cokeOwned;
		data.heroinOwned = heroinOwned;
		data.hours = hours;
		data.days = days;
		data.rep = rep;
		Debug.Log ("Saving to: " + Application.persistentDataPath);
		bf.Serialize (file, data);
		file.Close ();
		Debug.Log (cash.ToString());
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

			bankBalance = data.bankBalance;
			health = data.health;
			cash = data.cash;
			cryptoC = data.cryptoC;
			debtLeft = data.debtLeft;
			ludesOwned = data.ludesOwned;
			weedOwned = data.weedOwned;
			shroomOwned = data.shroomOwned;
			LSDOwned = data.LSDOwned;
			speedOwned = data.speedOwned;
			methOwned = data.methOwned;
			cokeOwned = data.cokeOwned;
			heroinOwned = data.heroinOwned;
			hours = data.hours;
			days = data.days;
			rep = data.rep;

		}
	}
}

// make the game data saveable
[Serializable]
class PlayerDataa
{
	
	public float health = PlayerCharacter.playChar.health;
	public float bankBalance = PlayerCharacter.playChar.bankBalance;
	public float cash = PlayerCharacter.playChar.cash;
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