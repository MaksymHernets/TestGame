using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWin : MonoBehaviour
{
	public void ButtonBack_Click()
	{
		SceneManager.LoadScene(0);
	}

	public void ButtonPlay_Click()
	{
		SceneManager.LoadScene(1);
	}
}
