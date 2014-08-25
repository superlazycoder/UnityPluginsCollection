//
//  HookBridge.cpp
//  OSHook
//
//  Created by The Lazy Coder on 8/23/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#include "HookBridge.h"
#import "OSHook.h"

void CallMethod(){
    // TODO: Othere Things
}

const char* ReturnString(){
    return "Hello There";
}

int ReturnInt(){
    return 5;
}

const char* CreateInstance(){
    return [[OSHook createInstance] cStringUsingEncoding:NSUTF8StringEncoding];
}

const int GetInstanceInt(const char* instanceKey){
    NSString *key = [NSString stringWithCString:instanceKey encoding:NSUTF8StringEncoding];
    OSHook *hook = [OSHook getInstanceForKey:key];
    return [hook returnInstanceInt];
}


void SendUnityBridgeMessage(const char* objectName, const char* messageName, const char* parameterString){
    
    [OSHook sendMessage:[NSString stringWithCString:messageName encoding:NSUTF8StringEncoding]
               toObject:[NSString stringWithCString:objectName encoding:NSUTF8StringEncoding]
          withParameter:[NSString stringWithCString:parameterString encoding:NSUTF8StringEncoding]];
    
}

