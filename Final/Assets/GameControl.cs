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
    public Text Player1_text;
    public Text Player2_text;
    public Text 結束顯示文字;
    public DisplayWord 顯示文字 = new ToDisplay();
    public GameObject 遊戲結束;
    public bool 可得分;
    public static int Player1_score;
    public static int Player2_score;
    public static GameControl Instance;
    public static bool 遊戲進行中;
    public static bool Player1有球權;

    // Use this for initialization
    void Start () {
        Vector2 球生成位置 = (Player1有球權) ? new Vector2(-6f, 3f) : new Vector2(6f, 3f);
        Instantiate(Load_from_Resources(Ball_obj), 球生成位置, new Quaternion());
        排球 = FindObjectOfType<Ball>();
        排球預設最大速度 = 排球.最大速度;

        Instantiate(Load_from_Resources(Player1_obj), new Vector2(-6f, -1.5f), new Quaternion());
        New_player1 = FindObjectOfType<Player1>();

        Instantiate(Load_from_Resources(Player2_obj), new Vector2(6f, -1.5f), new Quaternion());
        New_player2 = FindObjectOfType<Player2>();

        Player1_text.text = Player1_score.ToString();
        Player2_text.text = Player2_score.ToString();

        結束顯示文字 = 遊戲結束.GetComponent<Text>();
        Instance = this;
        可得分 = true;
	}

	// Update is called once per frame
	void Update () {
        if (遊戲進行中)
        {
            遊戲結束.SetActive(false);
            New_player1.移動();
            New_player2.移動();
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
            string 誰贏了 = Player1_score == 15 ? "Player 1" : "Player 2";
            顯示文字 = new AddOnce(顯示文字, 誰贏了);
            結束顯示文字.text = 顯示文字.輸出文字(結束顯示文字.text);
            遊戲結束.SetActive(true);
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("GameOver");
            }
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
            Player1有球權 = false;
        }
        else if (排球.水平位置 > 0)
        {
            Player1_score += 1;
            Player1_text.text = Player1_score.ToString();
            Player1有球權 = true;
        }
    }

    IEnumerator 重新載入()
    {
        yield return new WaitForSecondsRealtime(1.25f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}