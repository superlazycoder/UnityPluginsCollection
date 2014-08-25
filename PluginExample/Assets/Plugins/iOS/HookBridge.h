//
//  HookBridge.h
//  OSHook
//
//  Created by The Lazy Coder on 8/23/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//


extern "C" {
    
    void CallMethod();
    
    const char* ReturnString();
    
    int ReturnInt();
    
    const char* CreateInstance();
    
    const int GetInstanceInt(const char* instanceKey);
   
    
    void SendUnityBridgeMessage(const char* objectName, const char* messageName, const char* parameterString);
    
}
