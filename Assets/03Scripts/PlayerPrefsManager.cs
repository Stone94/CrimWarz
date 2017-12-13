﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour 
{
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	// level_unlocked_2

	public static void SetMasterVolume (float volume)
	{
		if (volume > 0f && volume < 1f) {
			PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, volume);
		} else {
			Debug.LogError ("master volume out of range");
		}
	}

	public static float GetMasterVolume ()
	{
		return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
	}

	public static void UnlockLevel (int level)
	{
		if (level <= SceneManager.sceneCount - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1); // use 1 for true
		} else {
			Debug.LogError("Trying to unlock nonexistent level");
		}
	}

	public static bool IsLevelUnlocked (int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString());
		bool isLevelUnlocked = (levelValue == 1);

		if (level <= SceneManager.sceneCount - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Trying to query level not in BUILD ORDER");
			return false;
		}
	}

	public static void SetDifficulty(float difficulty)
	{
		if (difficulty >= 1 && difficulty <= 3){
			PlayerPrefs.SetFloat (DIFFICULTY_KEY, difficulty);
		} else {
			Debug.Log ("Difficulty is out of range"); 
		}

	}

	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}

}
