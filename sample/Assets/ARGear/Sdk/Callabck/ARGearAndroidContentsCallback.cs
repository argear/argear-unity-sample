using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ARGear.Callback
{

    public class ARGearAndroidContentsCallback : AndroidJavaProxy
    {
        private event Action<string> OnSuccessAction;
        private event Action<string> OnErrorAction;

        public ARGearAndroidContentsCallback(Action<string> onSuccessAction, Action<string> onErrorAction)
            : base("com.argear.unityplugin.ARGearPlugin$IARGContentsResult")
        {
            if (onSuccessAction != null)
            {
                OnSuccessAction += onSuccessAction;
            }
            if (onErrorAction != null)
            {
                OnErrorAction += onErrorAction;
            }
        }

        public void OnSuccess()
        {
            if (OnSuccessAction != null)
            {
                OnSuccessAction("success");
            }
        }

        public void OnError(string msg)
        {
            if (OnErrorAction != null)
            {
                OnErrorAction(msg);
            }
        }
    }
}
