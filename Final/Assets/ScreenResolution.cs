using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour {

    void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.Escape))
            Screen.SetResolution(1540, 1130, true);
        else
            Screen.SetResolution(1131, 799, false);
    }

}
