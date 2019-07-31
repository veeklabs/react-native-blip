
#import "RNReactNativeBlipChat.h"
#import "BlipChat/BlipChat.h"


@implementation RNReactNativeBlipChat

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE();

RCT_EXPORT_METHOD(addEvent:(NSString *)name)
{
  [BlipClient openBlipThreadWithMyView:self appKey:(NSString*) @"bm92YXZlZWs6NGEwMDY4NzktMWZjYS00ZjBkLThmNDEtYmJiMTg3MmE4NmMy" options:options error: nil];
}

@end
