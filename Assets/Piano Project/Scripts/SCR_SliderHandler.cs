//ruth sofia brown
//git rsofia
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SCR_SliderHandler : MonoBehaviour
{
    float lastPostX;
    public Slider pitchSlider;
    private float deltaSlider = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Touch")
        {
            lastPostX = other.transform.position.x;
            print("Trigger activated");
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Touch")
        {
            float delta = other.transform.position.x - lastPostX;
            if (delta < 0)
            {
                pitchSlider.value -= deltaSlider;
            }
            else if (delta > 0)
            {
                pitchSlider.value += deltaSlider;
            }
            lastPostX = other.transform.position.x;
        }
        
    }
}
