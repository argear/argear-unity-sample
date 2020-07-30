using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARGear.Callback
{
    public class ARGearContentsCallback
    {
        private event Action<string> OnSuccessAction;
        private event Action<string> OnErrorAction;

        public ARGearContentsCallback(Action<string> onSuccessAction, Action<string> onErrorAction)
        {
            if (onSuccessAction != null)
                OnSuccessAction += onSuccessAction;

            if (onErrorAction != null)
                OnErrorAction += onErrorAction;
        }

        public void OnSuccess()
        {
            OnSuccessAction?.Invoke("success");

            ClearEvent();
        }

        public void OnError(string msg)
        {
            OnErrorAction?.Invoke(msg);

            ClearEvent();
        }

        private void ClearEvent()
        {
            OnSuccessAction = null;
            OnErrorAction = null;
        }
    }
}
