using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Interstitial : MonoBehaviour
{
    private InterstitialAd interstitial;
    void Start()
    {
        MobileAds.Initialize(initstatus => { });
        RequestInterstitial();
        if (interstitial.IsLoaded())
            interstitial.Show();

    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
            string adUnitId = "ca-app-pub-5598518304408848/8165837078";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-5598518304408848/8165837078";
#else
        string adUnitId = "unexpected_platform";
#endif
        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
}
