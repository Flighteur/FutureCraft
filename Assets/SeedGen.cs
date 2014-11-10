using UnityEngine;
using System.Collections;
using System;

public class SeedGen : MonoBehaviour {
    //This Script will generate a seed based on a phrase or System Date
	
    public string seed;
    // Use this for initialization
	void Start () {
        DateTime Date = DateTime.Now;
        Debug.Log(Date);
        
	}
}
