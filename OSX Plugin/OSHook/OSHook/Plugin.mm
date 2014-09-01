//
//  Plugin.cpp
//  OSLink
//
//  Created by Volure DarkAngel on 8/21/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#include "Plugin.h"
#include "OSLink.h"

const char* ReturnString(){
	return [[OSLink returnString] cStringUsingEncoding:NSUTF8StringEncoding];
}

int ReturnInt(){
	return [OSLink returnInt];
}

int AddInts(int a, int b) {
	return [OSLink addIntsA:a andB:b];
}

float AddFloats(float a, float b) {
	return [OSLink addFloatsA:a andB:b];
}


const char* CreateInstance(){
    return [[OSLink createInstance] cStringUsingEncoding:NSUTF8StringEncoding];
    
}
const char* ReturnInstanceString(const char* instanceKey){
    OSLink *myLink = [OSLink getInstanceWithKey:[NSString stringWithCString:instanceKey encoding:NSUTF8StringEncoding]];
    return [[myLink instanceString] cStringUsingEncoding:NSUTF8StringEncoding];
    
}
