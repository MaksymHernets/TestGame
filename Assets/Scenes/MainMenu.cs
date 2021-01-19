using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject buttonBack;

    public GameObject panelMain;
    public GameObject panelPlay;
    public GameObject panelOptions;

    public Text textVersion;

	private void Start()
	{
        textVersion.text = "Alpha " + Application.version;
    }

	public void ButtonPlay_Click()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonOptions_Click()
    {
        panelOptions.SetActive(true);
        buttonBack.SetActive(true);
        panelMain.SetActive(false);
    }

    public void ButtonBack_Click()
	{
        panelMain.SetActive(true);
        buttonBack.SetActive(false);
        panelPlay.SetActive(false);
        panelOptions.SetActive(false);
    }

    public void ButtonExit_Click()
    {
        Application.Quit();
    }
}
