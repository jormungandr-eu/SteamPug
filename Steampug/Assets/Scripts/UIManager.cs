///////////////////////////
// Default Unity Include //
using UnityEngine;
using System.Collections;

///////////////////////////////
// Used by UIManager.Play () //
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	public void Quit ()
	{
		Application.Quit();
	}

	public void Play ()
	{
		SceneManager.LoadScene("MainScene");
	}
}
