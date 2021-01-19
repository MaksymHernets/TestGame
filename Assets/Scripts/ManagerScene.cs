using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    public Player player;
    public Road road;

	public GameObject MenuGameOver;
	public GameObject MenuWin;
	public GameObject ButtonMenu;

	public GameObject ControlAndroid;
	public GameObject ControlKeyboard;

	public void Start()
	{
		player.CriticalMassEvent += CriticalMass;
		road.RoadClearEvent += RoadClear;
	}

	private void CriticalMass()
	{
		ButtonMenu.SetActive(false);
		MenuGameOver.SetActive(true);
		ControlAndroid.SetActive(false);
		ControlKeyboard.SetActive(false);
	}

	IEnumerator AnimationPlayer()
	{
		for (int i = 0; i < 80; ++i)
		{
			player.gameObject.transform.localPosition += new Vector3(0.1f, 0f, 0f);
			yield return new WaitForSeconds(0.03f);
		}
		
	}

	private void RoadClear()
	{
		MenuGameOver.SetActive(false);
		road.RoadClearEvent -= RoadClear;
		ControlAndroid.SetActive(false);
		ControlKeyboard.SetActive(false);
		ButtonMenu.SetActive(false);
		StartCoroutine(AnimationPlayer());
		MenuWin.SetActive(true);
	}

	private void PlayerToEndPoint()
	{
		MenuWin.SetActive(true);
	}
}
