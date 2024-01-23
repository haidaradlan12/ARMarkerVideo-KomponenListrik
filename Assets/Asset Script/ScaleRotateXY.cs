using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleRotateXY : MonoBehaviour
{
    public Slider ScaleSlider;
    public Slider RotateSlider_X;
    public Slider RotateSlider_Y;
    
    float currentRotateZ;
    
    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider.GetComponent<Slider>();
        RotateSlider_X.GetComponent<Slider>();
        RotateSlider_Y.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
        transform.localEulerAngles = new Vector3(RotateSlider_X.value, RotateSlider_Y.value, currentRotateZ);
    }
    
    public void AdjustScale(float newScale)
    {
        
    }
    public void AdjustAngle(float newAngle)
    {

    }
}
