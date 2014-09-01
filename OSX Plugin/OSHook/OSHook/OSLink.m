//
//  OSLink.m
//  OSLink
//
//  Created by Volure DarkAngel on 8/21/13.
//  Copyright (c) 2013 LoKi Systems. All rights reserved.
//

#import "OSLink.h"

@implementation OSLink

+(NSString*) returnString{
    return @"String returned";
}

+(int)returnInt{
    return 5;
}

+(int)addIntsA:(int)a andB:(int)b{
    return a + b;
}
+(float)addFloatsA:(float)a andB:(float)b{
    return a + b;
}

NSMutableDictionary *instanceDictionary;
+(NSString*)createInstance{
    
    if(instanceDictionary == nil) {
        instanceDictionary = [NSMutableDictionary dictionary];
    }
    
    
    
    NSString *instanceCode = [[NSUUID UUID] UUIDString];
    
    OSLink *myOSLink = [[OSLink alloc] init];
    
    [instanceDictionary setObject:myOSLink forKey:instanceCode];
    
    return instanceCode;
}

+(OSLink*) getInstanceWithKey:(NSString*) instanceKey{
    if (instanceDictionary == nil) {
        instanceDictionary = [NSMutableDictionary dictionary];
    }
    return [instanceDictionary objectForKey:instanceKey];
}

- (NSString *) instanceString{
    return @"Instance String Returned";
}


@end
