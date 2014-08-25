using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System;

public class PluginController : MonoBehaviour {
	
	private string buttonText = "Send Message";
	
	public TextMesh displayText;
	
	// Use this for initialization
	void Start () {
		
#if UNITY_IPHONE || UNITY_STANDALONE_OSX
		
		string data = Marshal.PtrToStringAuto(OSHookBridge.ReturnString());
		data += "\n" + OSHookBridge.ReturnInt();
		
		displayText.text = data;
		
		Debug.Log ("Returned Int = " + OSHookBridge.ReturnInt());
		Debug.Log ("Returned String = " + Marshal.PtrToStringAuto(OSHookBridge.ReturnString()));
		
		IntPtr handle = OSHookBridge.CreateInstance();
		Debug.Log("Returned Instance Int = " + OSHookBridge.GetInstanceInt(handle));
#elif UNITY_ANDROID 

		Debug.Log ("Returned Int = " + OSHookBridge.ReturnInt());
		Debug.Log ("Returned String = " + OSHookBridge.ReturnString());
		
		Debug.Log("Returned Instance Int = " + OSHookBridge.ReturnInstanceInt());
		Debug.Log("Returned Instance String = " + OSHookBridge.ReturnInstanceString());

#endif
		
	}
	
			
	// Update is called once per frame
	void Update () {
	
	}
	
	void SetButtonText(string newText){
		Debug.Log("Button Text = " + newText);
		buttonText = newText;
	}
	
	
	void OnGUI(){
		if (GUI.Button(new Rect(10,10,100,50),buttonText)){
			
			
			
#if UNITY_IPHONE
			
			IntPtr objectName = Marshal.StringToHGlobalAuto(this.name);
			IntPtr messageName = Marshal.StringToHGlobalAuto("SetButtonText");
			IntPtr parameterName = Marshal.StringToHGlobalAuto("New Text");
			
			OSHookBridge.SendUnityBridgeMessage(objectName,messageName,parameterName);
#elif UNITY_ANDROID
			//OSHookBridge.SendUnityMessage(this.name,"SetButtonText","New Text");
			
			OSHookBridge.ShowCamera(12345);
#endif
			
		}
	}
	
}
