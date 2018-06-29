using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Core;
using System;

public class GameControl : MonoBehaviour {
    public player1 new_player1;
    public player2 new_player2;
    public Ball 排球;
    public float 排球預設最大速度;
    public string player1_obj;
    public string player2_obj;
    public string player1的名字;
    public string player2的名字;
    public Text player1_text;
    public Text player2_text;
    public int player1_score = 0;
    public int player2_score = 0;
    public static GameControl Instance;
    public bool 遊戲進行中;

    // Use this for initialization
    void Start () {
        player1_obj = PlayerFactory.Create_player1_obj(Menu.charactorNo1);
        Instantiate(Load_from_Resources(player1_obj), new Vector2(-6f, 0), new Quaternion());
        new_player1 = FindObjectOfType<player1>();

        player2_obj = PlayerFactory.Create_player2_obj(Menu.charactorNo2);
        Instantiate(Load_from_Resources(player2_obj), new Vector2(6f, 0), new Quaternion());
        new_player2 = FindObjectOfType<player2>();

        排球 = FindObjectOfType<Ball>();
        排球預設最大速度 = 排球.最大速度;
        Instance = this;
        遊戲進行中 = true;
	}
	// Update is called once per frame
	void Update () {
        if (player1_score >= 15 || player2_score >= 15)
        {
            遊戲進行中 = false;
        }
        else
        {
            new_player1.移動();
            player1的名字 = new_player1.名字;
            new_player2.移動();
            player2的名字 = new_player2.名字;
        }
        排球.移動();
        排球.檢查碰撞();
        排球.殺球偵測();
       /* if (遊戲進行中&&排球.誰碰到球 == "ground")
        {
            排球.誰碰到球 = null;
            SceneManager.LoadScene("Main");
        }*/
	}

    void FixedUpdate() {
        if(!Input.GetKey(KeyCode.Escape))
            Screen.SetResolution(1540, 1130, true);
        else
            Screen.SetResolution(1131, 799, false);
    }
    private GameObject Load_from_Resources(string player_name)
    {
        return Resources.Load(player_name) as GameObject;
    }

    public void AddScore()
    {
        if (遊戲進行中)
        {
            if (排球.水平位置 < 0)
            {
                player2_score += 1;
                player2_text.text = ""+player2_score;
            }

            else if (排球.水平位置 > 0)
            {
                player1_score += 1;
                player1_text.text = "" + player1_score;
            }
        }
     }
}
