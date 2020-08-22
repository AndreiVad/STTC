using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartGame() {
        SceneManager.LoadScene(1);
        ChangeLevel();
        Time.timeScale = 1.0f;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        ChangeLevel();
        Time.timeScale = 1.0f;
    }



    public void ExitGame() {
        Application.Quit();
    }
    IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(2);
    }
}
