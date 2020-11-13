﻿using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class BannerAd : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public BannerAd(AndroidJavaObject javaObject) : base(javaObject) { }
       
        public BannerAd(AdStatusListener AdStatusListener) : base("org.m0skit0.android.hms.unity.ads.BannerAd", AndroidContext.ActivityContext, AdStatusListener) { }
         
        public string AdId
        {
            set;
            get;
        }

        public int PositionType
        {
            set;
            get;
        }
        public String SizeType
        {
            set;
            get;
        }
        public AdStatusListener AdStatusListener
        {
            set;
            get;
        }
        public void ShowBanner(AdParam adRequest) {
            HandleRequestAd(adRequest);  
        }
        public void HideBanner()
        {
             HandleHideAd();
        }
        public void DestroyBanner( )
        {
            HandleDestroyAd();
        }
        private void HandleRequestAd(AdParam adRequest)
        {
            AdStatusListener.mOnAdLoaded += OnAdLoadSuccess;
            AdStatusListener.mOnAdFailed += OnAdLoadFail; 
             
            Call("setAdId", AdId);

            Call("setBannerAdPosition", PositionType);
            
            Call("setAdSizeType", SizeType);

            Call("loadAd", adRequest);    
        }

        private void OnAdLoadFail(object sender, AdLoadErrorCodeEventArgs args)
        {
            Debug.Log("[HMS] Bannerads onAdLoadFail" + args);
        }
        private void OnAdLoadSuccess(object sender, EventArgs args)
        {
            Debug.Log("[HMS] Bannerads onAdLoadSuccess");
            Call("show");
        }

        private void HandleHideAd()
        {
            if (this != null)
            {
                 Call("hide");
            }
        }

        private void HandleDestroyAd()
        {
            if (this != null)
            {
                 Call("destroy");
            }
        }

    }
}