using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class WinMenu : MonoBehaviour
{
	string thisScene;
	void Start()
	{
		thisScene = SceneManager.GetActiveScene().name;
	}
	public void MainMenu()
	{
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
	}

	public void Next()
	{
        Time.timeScale = 1;
		if (thisScene == "Level01")
			SceneManager.LoadScene("Level02");
		else if (thisScene == "Level02")
			SceneManager.LoadScene("Level03");
		else
			SceneManager.LoadScene("MainMenu");
		/*
		bool levelCheck = false;
		bool levelLoad = false;
		string levelToLoad = "";
		var levels = new List<string>() { "Level01" , "Level02" , "Level03"};
        Time.timeScale = 1;
		foreach(string level in levels)
		{
			if (levelCheck && !(level == levels[levels.Count - 1]))
			{
				levelLoad = true;
				levelToLoad = level;
			}
			if (thisScene == level)
			{
				levelCheck = true;
			}
		}
		if (levelLoad)
			SceneManager.LoadScene(levelToLoad);
        SceneManager.LoadScene("MainMenu");
		*/
	}
}
