using UnityEngine;
using System.Collections;

public static class AndroidVibrate
{

#if UNITY_ANDROID && !UNITY_EDITOR
    public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#else
    public static AndroidJavaClass unityPlayer;
    public static AndroidJavaObject currentActivity;
    public static AndroidJavaObject vibrator;
#endif

    public static void Play(VibrateType type)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        switch (type)
        {
            case VibrateType.Default:
                Vibrate(500);
                break;
            case VibrateType.Peek:
                Vibrate(10);
                break;
            case VibrateType.Pop:
                Vibrate(20);
                break;
            case VibrateType.Cancelled:
                Vibrate(100);
                break;
            case VibrateType.TryAgain:
                Vibrate(200);
                break;
            case VibrateType.Failed:
                Vibrate(300);
                break;
        }
#endif
    }


    public static void Vibrate()
    {
        vibrator.Call("vibrate");
    }

    public static void Vibrate(long milliseconds)
    {
        vibrator.Call("vibrate", milliseconds);
    }

    public static void Vibrate(long[] pattern, int repeat)
    {
        vibrator.Call("vibrate", pattern, repeat);
    }
    public static void Cancel()
    {
        vibrator.Call("cancel");
    }

}
