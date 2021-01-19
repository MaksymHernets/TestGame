using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPlayer : MonoBehaviour
{
	public GameObject PlaceMenu;

    public void ButtonMenu_Click()
	{
		PlaceMenu.SetActive(!PlaceMenu.activeSelf);
	}

	public void ButtonLeave_Click()
	{
		SceneManager.LoadScene(0);
	}

	public void ButtonExit_Click()
	{
		Application.Quit();
	}
}
