using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Core;

public class Menu : MonoBehaviour {
    public GameObject Select_Player1;
    public GameObject Select_Player2;
    public GameObject click_to_start;
    public static int charactorNo1 = 0;
    public static int charactorNo2 = 0;
	// Use this for initialization
	void Start () {
        Select_Player2.SetActive(false);
        click_to_start.SetActive(false);
	}
    void FixedUpdate()
    {
        if (!Input.GetKey(KeyCode.Escape))
            Screen.SetResolution(1540, 1130, true);
        else
            Screen.SetResolution(1131, 799, false);
    }
    // Update is called once per frame
    void Update () {
		if (charactorNo1 != 0)
        {
            Select_Player1.SetActive(false);
            Select_Player2.SetActive(true);
            if (charactorNo2 != 0)
            {
                Select_Player2.SetActive(false);
                click_to_start.SetActive(true);
            }
        }
	}
    public void GotoMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void set_number_to1(GameObject 是誰)
    {
        if (是誰 == Select_Player1)
            charactorNo1 = 1;
        else
            charactorNo2 = 1;
    }

    public void set_number_to2(GameObject 是誰)
    {
        if (是誰 == Select_Player1)
            charactorNo1 = 2;
        else
            charactorNo2 = 2;
    }
}
