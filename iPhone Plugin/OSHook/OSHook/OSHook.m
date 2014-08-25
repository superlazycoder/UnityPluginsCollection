//
//  OSHook.m
//  OSHook
//
//  Created by The Lazy Coder on 8/23/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#import "OSHook.h"

@implementation OSHook

+ (int) returnInt{
    return 34;
}

+ (NSString*) returnString{
    return @"Static String";
}

- (int) returnInstanceInt{
    return 94632165;
}

- (NSString*) returnInstanceString{
    return @"Instance String";
}



NSMutableDictionary *_instanceHolder;
+ (NSMutableDictionary*)instanceHolder{
    if (_instanceHolder == nil){
        _instanceHolder = [[NSMutableDictionary alloc] init];
    }
    return _instanceHolder;
}


+ (NSString*) createInstance{
    
    NSUUID *myUUID = [NSUUID UUID];
    
    OSHook *_osHook = [[OSHook alloc] init];
    
    [[OSHook instanceHolder] setObject:_osHook forKey:[myUUID UUIDString]];
    
    
    
    return [myUUID UUIDString];
}

+ (OSHook*) getInstanceForKey:(NSString*) key{
    return [[OSHook instanceHolder] valueForKey:key];
}


+ (void) sendMessage:(NSString*) messageName
            toObject:(NSString*) objectName
       withParameter:(NSString*) parameterString{
    
    UnitySendMessage([objectName cStringUsingEncoding:NSUTF8StringEncoding],
                     [messageName cStringUsingEncoding:NSUTF8StringEncoding],
                     [parameterString cStringUsingEncoding:NSUTF8StringEncoding]);
    
}



@end
