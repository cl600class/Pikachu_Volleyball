using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;
public class collide_check : MonoBehaviour {
    public static string 誰碰到球;
    public static bool touched;

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
}
