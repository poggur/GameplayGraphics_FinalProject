using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EdgeDetectScript : MonoBehaviour
{
    [Header("Imports for shader value to update")]
    [SerializeField] private Material edgeCover;
    [SerializeField] private Material edgeDetect;

    private bool enabled = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleEdge()
    {
        if (enabled)
        {
            enabled = false;
        }
        else if (!enabled)
        {
            enabled = true;
        }

        edgeCover.SetInteger("_Enabled", Convert.ToInt32(enabled));
        edgeDetect.SetInteger("_Enabled", Convert.ToInt32(enabled));
    }

}
