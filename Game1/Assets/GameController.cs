using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject cubePrefab;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10; i++)
        {
            GameObject cubeObject = Instantiate(cubePrefab);
            cubeObject.transform.position = new Vector3(
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f),
                0
             );
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
