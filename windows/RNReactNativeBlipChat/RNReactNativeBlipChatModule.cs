using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Blip.Chat.RNReactNativeBlipChat
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeBlipChatModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeBlipChatModule"/>.
        /// </summary>
        internal RNReactNativeBlipChatModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeBlipChat";
            }
        }
    }
}
