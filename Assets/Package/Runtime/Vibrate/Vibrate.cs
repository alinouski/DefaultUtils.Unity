using System;

public static class Vibrate
{
    public static void Play(VibrateType type)
    {
        if (Vibro)
        {
#if UNITY_EDITOR
#elif UNITY_IOS && VIBRO
            iosVibrate.iosStartCustomVibrate((int)type);
#elif UNITY_ANDROID
            AndroidVibrate.Play(type);
#endif
        }
    }

    public static bool Vibro
    {
        get
        {
            return PlayerPrefsUtility.GetBool("Vibro", true);
        }

        set
        {
            PlayerPrefsUtility.SetBool("Vibro", value);
        }
    }

}

[Flags]
public enum VibrateType
{
    Default = 1 << 0,
    Peek = 1 << 1,
    Pop = 1 << 2,
    Cancelled = 1 << 3,
    TryAgain = 1 << 4,
    Failed = 1 << 5
}