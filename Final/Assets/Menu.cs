using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Core;

public class Menu : MonoBehaviour {
    public GameObject Select_Player1;
    public GameObject Select_Player2;
    public GameObject click_to_start;
    public static int charactorNo1;
    public static int charactorNo2;
	// Use this for initialization
	void Start () {
        Select_Player2.SetActive(false);
        click_to_start.SetActive(false);
        charactorNo1 = 0;
        charactorNo2 = 0;
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
                PreLoad();
            }
        }
	}
    public void GotoMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void Set_number_to1(GameObject 是誰)
    {
        if (是誰 == Select_Player1)
            charactorNo1 = 1;
        else
            charactorNo2 = 1;
    }

    public void Set_number_to2(GameObject 是誰)
    {
        if (是誰 == Select_Player1)
            charactorNo1 = 2;
        else
            charactorNo2 = 2;
    }

    public void PreLoad()
    {
        GameControl.遊戲進行中 = true;
        GameControl.Player1_score = 0;
        GameControl.Player2_score = 0;
        GameControl.Ball_obj = BallFactory.Create_ball(1);
        GameControl.Player1_obj = PlayerFactory.Create_player1_obj(charactorNo1);
        GameControl.Player2_obj = PlayerFactory.Create_player2_obj(charactorNo2);
    }
}
