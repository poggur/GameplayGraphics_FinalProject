using UnityEngine;
using UnityEngine.UI;

public class BlurSliderScript : MonoBehaviour
{
    [Header("Imports for shader value to update")]
    [SerializeField] private Material blurMaterial;
    [SerializeField] private Slider slider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSliderUpdate()
    {
        blurMaterial.SetFloat("_BlurAmount", slider.value);
    }
}
