﻿using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.WifiShare
{
   public  class WifiSharePolicy 
    { 
        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.Policy");
        public static WifiSharePolicy POLICY_MESH => androidJavaClass.GetStatic<WifiSharePolicy>("POLICY_SHARE");
        public static WifiSharePolicy POLICY_SET => androidJavaClass.GetStatic<WifiSharePolicy>("POLICY_SET");
    }
}
