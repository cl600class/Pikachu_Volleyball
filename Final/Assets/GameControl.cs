using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Core;
using System;

public class GameControl : MonoBehaviour {
    public Player1 New_player1;
    public Player2 New_player2;
    public Ball 排球;
    public float 排球預設最大速度;
    public static string Player1_obj;
    public static string Player2_obj;
    public static string Ball_obj;
    public string Player1的名字;
    public string Player2的名字;
    public Text Player1_text;
    public Text Player2_text;
    public bool 可得分;
    public static int Player1_score;
    public static int Player2_score;
    public static GameControl Instance;
    public static bool 遊戲進行中 = true;

    // Use this for initialization
    void Start () {
        Instantiate(Load_from_Resources(Ball_obj), new Vector2(-6f, 3f), new Quaternion());
        排球 = FindObjectOfType<Ball>();
        排球預設最大速度 = 排球.最大速度;

        Instantiate(Load_from_Resources(Player1_obj), new Vector2(-6f, -1.5f), new Quaternion());
        New_player1 = FindObjectOfType<Player1>();

        Instantiate(Load_from_Resources(Player2_obj), new Vector2(6f, -1.5f), new Quaternion());
        New_player2 = FindObjectOfType<Player2>();

        Player1_text.text = Player1_score.ToString();
        Player2_text.text = Player2_score.ToString();
        Instance = this;
        可得分 = true;
	}

	// Update is called once per frame
	void Update () {
        if (遊戲進行中)
        {
            New_player1.移動();
            Player1的名字 = New_player1.名字;
            New_player2.移動();
            Player2的名字 = New_player2.名字;
            if (排球.檢查得分() && 可得分)
            {
                加分();
                遊戲進行中 = !結束了沒();
                if (遊戲進行中)
                {
                    可得分 = false;
                    Time.timeScale = 0.3f;
                    StartCoroutine(重新載入());
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
                SceneManager.LoadScene("GameOver");
        }
        排球.移動();
        排球.檢查碰撞();
        排球.殺球控制(排球, New_player1, New_player2);
    }

    private GameObject Load_from_Resources(string object_name)
    {
        return Resources.Load(object_name) as GameObject;
    }

    private bool 結束了沒()
    {
        return (Player1_score >= 15 || Player2_score >= 15);
    }

    private void 加分()
    {
        if (排球.水平位置 < 0)
        {
            Player2_score += 1;
            Player2_text.text = Player2_score.ToString();
        }
        else if (排球.水平位置 > 0)
        {
            Player1_score += 1;
            Player1_text.text = Player1_score.ToString();
        }
    }

    IEnumerator 重新載入()
    {
        yield return new WaitForSecondsRealtime(1.25f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}