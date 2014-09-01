package com.lokisystems.oshook;

import android.content.Intent;
import android.provider.MediaStore;

import com.unity3d.player.UnityPlayer;

public class Bridge {
	public static String ReturnString(){
		return "Static String";
	}
	
	public static int ReturnInt(){
		return 5;
	}
	
	public int ReturnInstanceInt(){
		return 654984;
	}
	public String ReturnInstanceString(){
		return "Instance String";
	}
	
	public static void SendUnityMessage(String objectName, String methodName, String parameterText){
		com.unity3d.player.UnityPlayer.UnitySendMessage(objectName, methodName, parameterText);
	}
	
	public static void ShowCamera(int requestCode){
		Intent photoIntent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
		UnityPlayer.currentActivity.startActivityForResult(photoIntent, requestCode);
	}
	
	
}
