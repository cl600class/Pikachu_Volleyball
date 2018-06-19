using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;
public class collide_check : MonoBehaviour {
    public static bool touched;
    public static string 誰碰到球;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        誰碰到球 = collision.gameObject.tag;
        if (誰碰到球 == "player1" || 誰碰到球 == "player2" || 誰碰到球 == "ground")
        {
            touched = true;
            if (誰碰到球 == "ground")
                GameControl.Instance.AddScore();
        }
        else touched = false;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
