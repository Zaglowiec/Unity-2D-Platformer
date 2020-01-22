using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public string levelSelect;

	public string mainMenu;

	public bool isPaused;

	public GameObject pauseMenuCanvas;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isPaused)
		{
			pauseMenuCanvas.SetActive(true);
			Time.timeScale = 0f;
			Cursor.visible = true;
		}
		else
		{
			pauseMenuCanvas.SetActive(false);
			Time.timeScale = 1f;
			Cursor.visible = false;
		}

		if(Input.GetKeyDown(KeyCode.Escape))
		{
			PauseUnpause();
		}
	}

	public void PauseUnpause()
	{
		isPaused = !isPaused;
	}

	public void Resume()
	{
		isPaused = false;
	}

	public void LevelSelect()
	{
		Application.LoadLevel(levelSelect);
	}
	
	public void Quit()
	{
		Application.LoadLevel(mainMenu);
	}
}
