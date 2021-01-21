using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float Size = 1f;
	public float criticalmass = 0.3f;

	public GameObject spherePlayer;
    public GameObject prefabBullet;

	public Road road;

	private int _SizePull = 30;
	private GameObject[] ListBullet;
	public int activeBullets = 0;
	private int index = 0;
	private bool IsFullUse = false;
	private float _SpeedResize = 0.1f;

	public delegate void CriticalMass();
	public event CriticalMass CriticalMassEvent;

	private void Start()
	{
		spherePlayer.transform.localScale = new Vector3(Size, Size, Size);
		road.transform.localScale = new Vector3(road.transform.localScale.x, road.transform.localScale.y, Size * 0.1f);

		ListBullet = new GameObject[_SizePull];
		for (int i = 0; i < _SizePull; ++i)
		{
			ListBullet[i] = GameObject.Instantiate(prefabBullet);
		}
	}

	public void BeginExcretionMass()
	{
		for (int i = 0; i < _SizePull; ++i)
		{
			if (ListBullet[i].activeSelf == false)
			{
				ListBullet[i].transform.position = prefabBullet.transform.position;
				ListBullet[i].transform.localScale = new Vector3(0f, 0f, 0f);
				ListBullet[i].SetActive(true);
				++activeBullets;
				index = i;
				IsFullUse = false;
				ExcretionMass();
				return;
			}
		}
		IsFullUse = true;
	}

	public void ExcretionMass()
	{
		if ( IsFullUse == false)
		{
			var value = _SpeedResize * Time.deltaTime;
			spherePlayer.transform.localScale -= new Vector3(value, value, value);
			ListBullet[index].transform.localScale += new Vector3(value, value, value);
			road.gameObject.transform.localScale -= new Vector3(0, 0, value * 0.1f);

			if (spherePlayer.transform.localScale.x <= criticalmass)
			{
				CriticalMassEvent();
			}
		}
	}

	public void BallThrow()
	{
		if (IsFullUse == false)
		{
			ListBullet[index].GetComponent<Rigidbody>().AddForce(new Vector3(70, 0, 0));
		}
	}
}
