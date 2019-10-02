using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateButton : MonoBehaviour
{
    public void Play()
    {
        Vibrate.Play(VibrateType.Pop);
    }
}
