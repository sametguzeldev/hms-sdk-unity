namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidIntent : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.content.Intent";

        
        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidIntent(AndroidJavaClass activityClass) : base(CLASS_NAME, AndroidContext.ActivityContext, activityClass) { }

        public AndroidJavaObject Intent => JavaObject;

        public int GetIntExtra(string name) => Call<int>("getIntExtra", name, 1);
        public bool GetHasExtra(string name) => Call<bool>("hasExtra", name);
        public string GetStringExtra(string name) => CallAsString("getStringExtra", name);
        public AndroidBundle GetParcelableExtra<T>(string name) => CallAsWrapper<AndroidBundle>("getParcelableExtra", name);



    }
}
