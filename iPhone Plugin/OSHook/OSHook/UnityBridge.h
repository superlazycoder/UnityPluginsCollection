//
//  UnityBridge.h
//  OSHook
//
//  Created by Jason McKinley on 8/26/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#ifndef OSHook_UnityBridge_h
#define OSHook_UnityBridge_h


#ifdef __cplusplus
extern "C" {
#endif
    void UnitySendMessage(const char* obj, const char* method, const char* msg);
#ifdef __cplusplus
}
#endif


#endif
