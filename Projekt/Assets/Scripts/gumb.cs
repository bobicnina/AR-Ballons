using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;



public class gumb : MonoBehaviour {

	System.Random r = new System.Random(DateTime.Now.Millisecond);
 
 	public Color RandomColor(){
    				byte red = (byte)r.Next(0, 255);
    				byte green = (byte)r.Next(0, 255);
    				byte blue = (byte)r.Next(0, 255);
 
			return new Color(red, green, blue);  }
	
	public Renderer Rend;


	public void buttonPressed(){
		GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
		//Rend.sharedMaterial.color = RandomColor();
	}
}

