using System;
using UnityEngine;
using UnityEngine.UI;

public class RadialBlurScript : MonoBehaviour
{
    [Header("Imports for shader value to update")]
    [SerializeField] private Material radialBlur;
    [SerializeField] private Slider slider;

    private bool enabled = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleBlur()
    {
        if (enabled)
        {
            enabled = false;
        }
        else if (!enabled)
        {
            enabled = true;
        }

        radialBlur.SetInteger("_Enabled", Convert.ToInt32(enabled));
    }

    public void OnSliderUpdate()
    {
        radialBlur.SetFloat("_BlurAmount", slider.value);
    }
}
