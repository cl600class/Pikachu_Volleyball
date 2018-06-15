using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class GameControl : MonoBehaviour {
    public player1 new_player1;
    public string 名字;
	// Use this for initialization
	void Start () {
        new_player1 = FindObjectOfType<player1>();
	}
	// Update is called once per frame
	void Update () {
        new_player1.移動();
        名字 = new_player1.name;
	}
}
