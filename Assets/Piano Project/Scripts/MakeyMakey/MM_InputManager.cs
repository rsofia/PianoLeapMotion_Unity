//ruth sofia brown
//git rsofia
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MM_InputManager : MonoBehaviour
{
    //wasd fg
    public SCR_RecieveTouch[] notas; 

	void Update ()
	{
        if (Input.GetKeyDown(KeyCode.W))
            notas[0].PlayKey();
        if (Input.GetKeyDown(KeyCode.A))
            notas[1].PlayKey();
        if (Input.GetKeyDown(KeyCode.S))
            notas[2].PlayKey();
        if (Input.GetKeyDown(KeyCode.D))
            notas[3].PlayKey();
        if (Input.GetKeyDown(KeyCode.F))
            notas[4].PlayKey();
        if (Input.GetKeyDown(KeyCode.G))
            notas[5].PlayKey();
    }
}
