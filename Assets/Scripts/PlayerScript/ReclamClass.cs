using Mycom.Target.Unity.Ads;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReclamClass
{
    public int countLoose = 0;
    public uint ANDROID_SLOT_ID = 10138;

    private InterstitialAd _interstitialAd;

    InterstitialAd CreateInterstitial()
    {
        UInt32 slotId = 10138;
#if UNITY_ANDROID
        slotId = ANDROID_SLOT_ID;
#elif UNITY_IOS
    slotId = IOS_SLOT_ID;
#endif

        // Включение режима отладки
        // InterstitialAd.IsDebugMode = true;
        // Создаем экземпляр InterstitialAd
        return new InterstitialAd(slotId);
    }

    public void InitAd()
    {
        // Создаем экземпляр InterstitialAd
        _interstitialAd = CreateInterstitial();

        // Запускаем загрузку данных
        _interstitialAd.Load();
    }

    public void Show()
    {
        _interstitialAd.Show();
    }
}