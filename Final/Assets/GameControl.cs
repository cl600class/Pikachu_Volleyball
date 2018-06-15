using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class GameControl : MonoBehaviour {
    public player1 new_player1;
    public GameObject player1_obj;
    public string 名字;


	// Use this for initialization
	void Start () {
        player1_obj = PlayerFactory.Create_player1_obj(2);
        Instantiate(player1_obj, new Vector2(-6, 0), new Quaternion());
        new_player1 = FindObjectOfType<player1>();
	}
	// Update is called once per frame
	void Update () {
        new_player1.移動();
        名字 = new_player1.name;
	}
}
