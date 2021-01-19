using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    public GameObject prefab;
    public GameObject contect;

    void Start()
    {
        Spawn(-2f, 3f, -5f, 5f, 100);
    }

    private void Spawn(float x1, float x2, float y1, float y2, float count)
	{
        for (int i = 0; i < count; ++i)
        {
            var newitem = GameObject.Instantiate(prefab, contect.transform);
            newitem.SetActive(true);
            newitem.transform.position = new Vector3(Random.Range((float)x1, (float)x2), .15f, Random.Range((float)y1, (float)y2));
        }
    }        
}
