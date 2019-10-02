using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VibroButtonController : MonoBehaviour
{
    public Sprite on;
    public Sprite off;

    public Image[] jointSprites;
    public bool useColor = false;
    public Color onColor;
    public Color offColor;

    private void Awake()
    {
        CheckImage();
    }

    public void Click()
    {
        Vibrate.Vibro = !Vibrate.Vibro;
        CheckImage();
    }

    private void CheckImage()
    {
        if (Vibrate.Vibro)
        {
            foreach (Image s in jointSprites)
            {
                if (useColor)
                    s.color = onColor;
                s.sprite = on;
            }
        }
        else
        {
            foreach (Image s in jointSprites)
            {
                if (useColor)
                    s.color = offColor;
                s.sprite = off;
            }
        }
    }
}