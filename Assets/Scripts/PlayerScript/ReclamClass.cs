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

        // ��������� ������ �������
        // InterstitialAd.IsDebugMode = true;
        // ������� ��������� InterstitialAd
        return new InterstitialAd(slotId);
    }

    public void InitAd()
    {
        // ������� ��������� InterstitialAd
        _interstitialAd = CreateInterstitial();

        // ��������� �������� ������
        _interstitialAd.Load();
    }

    public void Show()
    {
        _interstitialAd.Show();
    }
}