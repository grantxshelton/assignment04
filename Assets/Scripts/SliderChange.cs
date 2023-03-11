using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderChange : MonoBehaviour
{
    public Text carSliderText;
    public Text spawnSliderText;
    public Slider carSlider;
    public Slider spawnSlider;
    public static float carSliderVal;
    public static float spawnSliderVal;

    void Start()
    {
        carSliderVal = 50; // Defaults slider value to 50%
    }
    // Update is called once per frame
    void Update()
    {

        carSliderVal = ((float)carSlider.value);
        Car.maxSpeed = carSlider.value * 2;
        carSliderText.text = "Car Speed: " + ((carSlider.value/12) * 100).ToString("#") + "%";

        spawnSliderVal = ((float)spawnSlider.value);
        CarSpawner.spawnDelay = spawnSlider.value;  
        spawnSliderText.text = "Spawn Delay: " + spawnSliderVal.ToString("#.##") + "(s)";

    }
}
