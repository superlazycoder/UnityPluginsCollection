//
//  OSHook.h
//  OSHook
//
//  Created by The Lazy Coder on 8/23/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface OSHook : NSObject

+ (int) returnInt;

+ (NSString*) returnString;

- (int) returnInstanceInt;

- (NSString*) returnInstanceString;

+ (NSString*) createInstance;

+ (OSHook*) getInstanceForKey:(NSString*) key;


+ (void) sendMessage:(NSString*) messageName toObject:(NSString*) objectName withParameter:(NSString*) parameterString;

@end
