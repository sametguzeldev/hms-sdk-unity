namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class AppUpdateClientWrapper : JavaObjectWrapper, IAppUpdateClient
    {
        public AppUpdateClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void CheckAppUpdate(ICheckUpdateCallback checkUpdateCallback)
        {
            Call("checkAppUpdate", AndroidContext.ActivityContext, new CheckUpdateCallbackWrapper(checkUpdateCallback));
        }

        public void ReleaseCallback()
        {
            Call("releaseCallback");
        }
    }
}
