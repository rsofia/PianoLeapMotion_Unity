//ruth sofia brown
//git rsofia
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SCR_PitchController : MonoBehaviour
{
    AudioSource[] allAudios;
    float pitch = 1;
    public Slider pitchSlider;

	void Start ()
	{
        allAudios = FindObjectsOfType<AudioSource>();
	}	

    public void ModifyPitch()
    {
        for(int i = 0; i < allAudios.Length; i++)
        {
            allAudios[i].pitch = pitchSlider.value;
        }
    }
}
