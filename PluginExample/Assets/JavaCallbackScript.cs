using UnityEngine;
using System.Collections;
using System;

public class JavaCallbackScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void onActivityResult(string resultData){
		Debug.Log("onActivityResult = " + resultData);
		
		string[] sTmp = resultData.Split(new string[] {":"},StringSplitOptions.None);
		
		if (sTmp.Length > 1){
			Debug.Log("requestCode = " + sTmp[0]);
			Debug.Log ("responseCode = " + sTmp[1]);
			
		}
		
		
		
	}
	
}
