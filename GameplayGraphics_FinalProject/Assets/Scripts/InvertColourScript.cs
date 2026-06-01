using System;
using UnityEngine;

public class InvertColourScript : MonoBehaviour
{
    [Header("Invert colour screen overlay material")]
    [SerializeField] private Material invertColourMat;

    private bool enabled = false;
    private bool redEnabled, greenEnabled, blueEnabled = true;

    private void Start()
    {
        invertColourMat.SetInteger("_Enabled", Convert.ToInt32(enabled));
        invertColourMat.SetInteger("_Red_Inversion", Convert.ToInt32(redEnabled));
        invertColourMat.SetInteger("_Green_Inversion", Convert.ToInt32(greenEnabled));
        invertColourMat.SetInteger("_Blue_Inversion", Convert.ToInt32(blueEnabled));
    }

    public void EnableInversion()
    {
        if (enabled)
        {
            enabled = false;
        }
        else if (!enabled)
        {
            enabled = true;
        }
        invertColourMat.SetInteger("_Enabled", Convert.ToInt32(enabled));
    }

    public void RedInvert()
    {
        if (redEnabled)
        {
            redEnabled = false;
        }
        else if (!redEnabled)
        {
            redEnabled = true;
        }
        invertColourMat.SetInteger("_Red_Inversion", Convert.ToInt32(redEnabled));
    }

    public void GreenInvert()
    {
        if (greenEnabled)
        {
            greenEnabled = false;
        }
        else if (!redEnabled)
        {
            greenEnabled = true;
        }
        invertColourMat.SetInteger("_Green_Inversion", Convert.ToInt32(greenEnabled));
    }

    public void BlueInvert()
    {
        if (blueEnabled)
        {
            blueEnabled = false;
        }
        else if (!blueEnabled)
        {
            blueEnabled = true;
        }
        invertColourMat.SetInteger("_Blue_Inversion", Convert.ToInt32(blueEnabled));
    }
}
