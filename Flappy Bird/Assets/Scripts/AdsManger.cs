using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using admob;

public class AdsManger : MonoBehaviour
{

    public static AdsManger instance;
    // Start is called before the first frame update
    public static AdsManger Instance
    {
       get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<AdsManger>();
            }
            return instance;

        }
    }
        Admob ad;
        //string appID="";
        string bannerID = "";
        string interstitialID = "";
        string videoID = "";
        string nativeBannerID = "";

    private void Awake()
    {
#if UNITY_IOS
        		// appID="ca-app-pub-3940256099942544~1458002511";
				 bannerID="ca-app-pub-3940256099942544/2934735716";
				 interstitialID="ca-app-pub-3940256099942544/4411468910";
				 videoID="ca-app-pub-3940256099942544/1712485313";
				 nativeBannerID = "ca-app-pub-3940256099942544/3986624511";
#elif UNITY_ANDROID
        //appID="ca-app-pub-2971252247570492~7083194859";
        bannerID = "ca-app-pub-2971252247570492/3459876129";
        interstitialID = "ca-app-pub-2971252247570492/9123034835";
#endif
        AdProperties adProperties = new AdProperties();
        adProperties.isTesting(false);
        adProperties.isAppMuted(true);
        adProperties.isUnderAgeOfConsent(false);
        adProperties.appVolume(100);
        adProperties.maxAdContentRating(AdProperties.maxAdContentRating_G);
        string[] keywords = { "diagram", "league", "brambling" };
        adProperties.keyworks(keywords);

        ad = Admob.Instance();
        ad.bannerEventHandler += onBannerEvent;
        ad.interstitialEventHandler += onInterstitialEvent;
        ad.initSDK(adProperties);//reqired,adProperties can been null
    }
    public void ShowBannerAds()
    {
        Admob.Instance().showBannerRelative(bannerID, AdSize.SMART_BANNER, AdPosition.BOTTOM_CENTER);
    }
    public void ShowInterstitialAds()
    {
        Debug.Log("touch inst button -------------");
        if (ad.isInterstitialReady())
        {
            ad.showInterstitial();
        }
        else
        {
            ad.loadInterstitial(interstitialID);
        }
    }
    void onInterstitialEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
        if (eventName == AdmobEvent.onAdLoaded)
        {
            Admob.Instance().showInterstitial();
        }
    }
    void onBannerEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
    }
}
