using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmovement : MonoBehaviour {

    public float amplitude = 1;
    public float freq = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, Mathf.Sin(Time.time * freq) * amplitude, 0);

    }
}
