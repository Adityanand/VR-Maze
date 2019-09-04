using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMAnger : MonoBehaviour {

	// Use this for initialization
	public void Exit()
    {
        Application.Quit();
	}
	
	// Update is called once per frame
	public void TryAgain ()
    {
        SceneManager.LoadScene("VR Test");
	}
}
