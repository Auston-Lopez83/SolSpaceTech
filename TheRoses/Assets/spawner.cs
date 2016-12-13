using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

	public Transform[] spawnLocations;
	public GameObject[] flowerPreFab;
	public GameObject[] flowerClone;

	void Start()
	{
		flowerSpawner ();
	}

	void flowerSpawner()
	{
		//flowerClone[0] = Instantiate (flowerPreFab [0], spawnLocations [0].transform.parent , Quaternion.Euler (0, 0, 0)) as GameObject;
	}
}