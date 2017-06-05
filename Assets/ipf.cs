using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ipf : MonoBehaviour {

    [SerializeField] GlitchManager glitchM;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TriggerGlitch()
    {
        glitchM.GlitchScreenOnCommand(0.1f, 2f);
        
    }

}
