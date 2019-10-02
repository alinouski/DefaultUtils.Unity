using System.Runtime.InteropServices;

public static class iosVibrate
{
#if UNITY_IOS && !UNITY_EDITOR && VIBRO
    private const string __module__ = "__Internal";
    [DllImport(__module__)] public static extern void iosStartCustomVibrate(int type);
#endif
}
