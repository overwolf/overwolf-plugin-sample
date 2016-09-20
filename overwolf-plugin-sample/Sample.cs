using System;
using System.Threading.Tasks;

namespace overwolf.samples.plugins {
  public class SamplePlugin {
    // a global event that triggers with two parameters:
    //
    // plugin.get().onGlobalEvent.addListener(function(first, second) {
    //  ...
    // });
    public event Action<object, object> onGlobalEvent;

    // a property
    //
    // console.log(plugin.get().SampleProperty);
    public int SampleProperty {
      get { 
        return 42; 
      }
    }

    // plugin.get().add(5, 4, function(result) {
    //   console.log("5 + 4 = " + result);
    // });
    // 
    // notice how we will always call the callback on a new thread
    public void add(int x, int y, Action<object> callback) {
      if (callback == null) {
        return;
      }

      Task.Run(() => {
        try {
          callback(x + y);
        } catch (Exception) {
          callback(-1);
        }
      });
    }

    // plugin.get().onGlobalEvent.addListener(function(first, second) {
    //  ...
    // });
    //
    // plugin.get().triggerGlobalEvent();
    public void triggerGlobalEvent() {
      if (onGlobalEvent == null) {
        return;
      }

      Task.Run(() => {
        onGlobalEvent("first value", "second value");
      });
    }
  }
}
