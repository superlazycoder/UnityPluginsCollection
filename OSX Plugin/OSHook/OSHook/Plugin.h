//
//  Plugin.h
//  OSLink
//
//  Created by Volure DarkAngel on 8/21/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//


extern "C" {
	const char* ReturnString ();
	int ReturnInt ();
	int AddInts(int, int);
	float AddFloats(float, float);
    
    // Instance Code
    const char* CreateInstance();
    const char* ReturnInstanceString(const char*);
}