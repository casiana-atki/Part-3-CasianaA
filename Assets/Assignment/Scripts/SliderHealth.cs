using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class SliderHealth : MonoBehaviour
{
    public Slider slider;

    public void Start()
    {
        slider.value = 5;
    }
    public void CurrentHealth(int health)
    {
        slider.value -= health;

    }
}
