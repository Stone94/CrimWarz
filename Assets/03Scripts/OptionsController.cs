using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
	
	public Slider volumeSlide, difficultySlide;
	public LevelManager levelManager;

	private MusicManager musicManager;
	//TODO Repurpose this for use in meh game


	// Use this for initialization
	void Start () {
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
		volumeSlide.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlide.value = PlayerPrefsManager.GetDifficulty ();
		volumeSlide.value = 0.8f;
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.ChangeVolume (volumeSlide.value);
	}

	public void SaveAndExit()
	{
		PlayerPrefsManager.SetMasterVolume (volumeSlide.value);
		PlayerPrefsManager.SetDifficulty (difficultySlide.value);
		levelManager.LoadLevel ("01a Start");

	}

	public void SetDefaults()
	{
		volumeSlide.value = 0.8f;
		difficultySlide.value = 1f;
	}


}
