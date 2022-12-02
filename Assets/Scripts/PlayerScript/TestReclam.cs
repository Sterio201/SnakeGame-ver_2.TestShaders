using Mycom.Target.Unity.Ads;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReclam : MonoBehaviour
{
    [SerializeField] uint ANDROID_SLOT_ID;

    private void Start()
    {
        InitAd();
    }

    InterstitialAd CreateInterstitial()
    {
        UInt32 slotId = ANDROID_SLOT_ID;
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

    private InterstitialAd _interstitialAd;

    private void InitAd()
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