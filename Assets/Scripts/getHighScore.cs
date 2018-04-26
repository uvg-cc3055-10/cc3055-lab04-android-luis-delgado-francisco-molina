using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHighScore : MonoBehaviour {
    public Text texto;
	// Use this for initialization
	void Start ()
    {
        texto.text = PlayerPrefs.GetFloat("HighScore").ToString("F0");

    }
	
	// Update is called once per frame
	void Update () {
    }
}
