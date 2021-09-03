using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
	public void startthegame (string startgame)
	{
		Application.LoadLevel ("Game");
	}
	public void quitthegame (string quit)
	{
		Application.Quit();
	}


}
