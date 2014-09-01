//
//  OSLink.h
//  OSLink
//
//  Created by Volure DarkAngel on 8/21/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface OSLink : NSObject

+(NSString*) returnString;
+(int) returnInt;
+(int) addIntsA:(int)a andB:(int)b;
+(float) addFloatsA:(float)a andB:(float)b;
+(NSString*) createInstance;
+(OSLink*) getInstanceWithKey:(NSString*) instanceKey;

-(NSString*) instanceString;
@end
