
import { NativeModules } from 'react-native';

const { RNBlipChat } = NativeModules;

export default {
  openThread: () => {
    RNBlipChat.addEvent('Test');
  }
}
