using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 

public class ClockTimer : MonoBehaviour
{
    public Slider slider;
    float timer;
    public float speed = 1f; 

    private void Update()
    {
        timer += Time.deltaTime * speed;
        timer = timer % 60;
        slider.value = timer; 
    }
}
