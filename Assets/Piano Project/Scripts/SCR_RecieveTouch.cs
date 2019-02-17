//ruth sofia brown
//git rsofia
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SCR_RecieveTouch : MonoBehaviour
{
    AudioSource au;
    Material myMat;
    public Material selected;
    private float delay = 0.3f;

	void Start ()
	{
        au = GetComponent<AudioSource>();
        myMat = GetComponent<Renderer>().material;
	}

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Touch"))
        {
            //Debug.Log(gameObject.name);
            PlayKey();
        }
    }

    public void PlayKey()
    {
        au.Play();
        StartCoroutine(WaitToTurnBack());
    }

    IEnumerator WaitToTurnBack()
    {
        GetComponent<Renderer>().material = selected;
        yield return new WaitForSeconds(delay);
        GetComponent<Renderer>().material = myMat;
    }
}
