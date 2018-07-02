using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;
public class Collide_check : MonoBehaviour {

    public string 誰碰到球;
    public bool touched;
    public bool 得分;
    public static Collide_check Instance;

    public void OnTriggerEnter2D(Collider2D Collision)
    {
        誰碰到球 = Collision.gameObject.tag;
        if (誰碰到球 == "player1" || 誰碰到球 == "player2" || 誰碰到球 == "ground")
        {
            touched = true;
            if (誰碰到球 == "ground")
            {
                得分 = true;
            }
        }
        else
        {
            touched = false;
            得分 = false;
        }
    }

    void Start()
    {
        Instance = this;
        誰碰到球 = null;
        得分 = false;
    }
}
