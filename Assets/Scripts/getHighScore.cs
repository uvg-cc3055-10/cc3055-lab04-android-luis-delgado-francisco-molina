using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getHighScore : MonoBehaviour {
    public Text texto;
	// Use this for initialization
	void Start ()
    {
        if (0 == PlayerPrefs.GetFloat("HighScore"))
            PlayerPrefs.SetFloat("HighScore", 0f);

    }
	
	// Update is called once per frame
	void Update () {
		texto.text= PlayerPrefs.GetFloat("HighScore").ToString("F0");
    }
}
