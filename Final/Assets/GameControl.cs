using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Core;

public class GameControl : MonoBehaviour {
    public player1 new_player1;
    public player2 new_player2;
    public string player1_obj;
    public string player2_obj;
    public string player1的名字;
    public string player2的名字;
    public Text player1_text;
    public Text player2_text;
    public int player1_score = 0;
    public int player2_score = 0;
    public static GameControl Instance;

    // Use this for initialization
    void Start () {
        player1_obj = PlayerFactory.Create_player1_obj(1);
        Instantiate(Load_from_Resources(player1_obj), new Vector2(-6f, 0), new Quaternion());
        new_player1 = FindObjectOfType<player1>();

        player2_obj = PlayerFactory.Create_player2_obj(1);
        Instantiate(Load_from_Resources(player2_obj), new Vector2(6f, 0), new Quaternion());
        new_player2 = FindObjectOfType<player2>();

        Instance = this;
	}
	// Update is called once per frame
	void Update () {
        new_player1.移動();
        player1的名字 = new_player1.名字;
        new_player2.移動();
        player2的名字 = new_player2.名字;
	}
    private GameObject Load_from_Resources(string player_name)
    {
        return Resources.Load(player_name) as GameObject;
    }

    public void AddScore()
    {
        if (ball.GetHorizontalPosition() < 0)
        {
            player2_score += 1;
            player2_text.text = ""+player2_score;
        }

        else if (ball.GetHorizontalPosition() > 0)
        {
            player1_score += 1;
            player1_text.text = "" + player1_score;
        }

    }
}
