using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawNoise : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 something;
        something = Mathf.PerlinNoise(10, 10);
	}
}
