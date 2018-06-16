using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class GameControl : MonoBehaviour {
    public player1 new_player1;
    public player2 new_player2;
    public GameObject player1_obj;
    public GameObject player2_obj;
    public string player1的名字;
    public string player2的名字;


    // Use this for initialization
    void Start () {
        player1_obj = PlayerFactory.Create_player1_obj(1);
        Instantiate(player1_obj, new Vector2(-6, 0), new Quaternion());
        new_player1 = FindObjectOfType<player1>();

        player2_obj = PlayerFactory.Create_player2_obj(1);
        Instantiate(player2_obj, new Vector2(5, 0), new Quaternion());
        new_player2 = FindObjectOfType<player2>();
	}
	// Update is called once per frame
	void Update () {
        new_player1.移動();
        player1的名字 = new_player1.name;
        new_player2.移動();
        player2的名字 = new_player2.name;
	}
}
