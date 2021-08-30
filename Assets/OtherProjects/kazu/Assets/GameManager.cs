using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject EnemyPrefab;
	private float interval = 2.0f;
	private float timeElapsed = 0.0f;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= interval)
		{
			timeElapsed = 0.0f;
			Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -3.7f), 0);
			Instantiate(EnemyPrefab, randamPos, Quaternion.identity);
		}
	}
}