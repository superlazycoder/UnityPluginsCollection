using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class OSHookBridge
{
	
	
	
#if UNITY_STANDALONE_OSX
	//
//  HookBridge.h
//  OSHook
//
//  Created by The Lazy Coder on 8/23/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//
	
	[DllImport("OSHook")]
    public static extern IntPtr  ReturnString();
    
	[DllImport("OSHook")]
    public static extern int ReturnInt();
	
	[DllImport("OSHook")]
    public static extern IntPtr CreateInstance();
    
	[DllImport("OSHook")]
    public static extern int GetInstanceInt(IntPtr instanceKey);

	[DllImport("OSHook")]
    public static extern void SendUnityBridgeMessage(IntPtr objectName, IntPtr messageName, IntPtr parameterString);

	
#elif UNITY_IPHONE 
	
	[DllImport("__Internal")]
    public static extern void CallMethod();
    
	[DllImport("__Internal")]
    public static extern IntPtr  ReturnString();
    
	[DllImport("__Internal")]
    public static extern int ReturnInt();
	
	[DllImport("__Internal")]
	public static extern IntPtr CreateInstance();
    
	[DllImport("__Internal")]
	public static extern int GetInstanceInt(IntPtr instanceKey);

	[DllImport("__Internal")]
	public static extern void SendUnityBridgeMessage(IntPtr objectName, IntPtr messageName, IntPtr parameterString);

#elif UNITY_ANDROID
	
	public static string ReturnString(){
		AndroidJavaClass ajc = new AndroidJavaClass("com.lokisystems.oshook.Bridge");
		return ajc.CallStatic<string>("ReturnString");
		
	}
	
	public static int ReturnInt(){
		AndroidJavaClass ajc = new AndroidJavaClass("com.lokisystems.oshook.Bridge");
		return ajc.CallStatic<int>("ReturnInt");
	}
	
	public static string ReturnInstanceString(){
		AndroidJavaObject ajo = new AndroidJavaObject("com.lokisystems.oshook.Bridge");
		return ajo.Call<string>("ReturnInstanceString");
	}
	
	public static int ReturnInstanceInt(){
		AndroidJavaObject ajo = new AndroidJavaObject("com.lokisystems.oshook.Bridge");
		return ajo.Call<int>("ReturnInstanceInt");
	}
	
	public static void SendUnityMessage(string objectName, string methodName, string parameterText){
		AndroidJavaClass ajc = new AndroidJavaClass("com.lokisystems.oshook.Bridge");
		ajc.CallStatic("SendUnityMessage", objectName, methodName, parameterText);
	}
	
	public static void ShowCamera(int requestCode){
		AndroidJavaClass ajc = new AndroidJavaClass("com.lokisystems.oshook.Bridge");
		ajc.CallStatic("ShowCamera",requestCode);
	}
	
	
#endif 
	
}

