using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class Ball : MonoBehaviour, IMoveable {
    public Rigidbody2D 球;
    public float 目前水平速度;
    public float 目前垂直速度;
    public Vector2 目前速度;
    public float 目前速率;
    public Vector2 調整後速度;
    public float 調整後速率;
    public float 最小速度;
    public float 最大速度;
    public float 水平位置;
    public bool touched;
    public string 誰碰到球;
    public static Ball Instance;

    public virtual void 移動()
    {

    }

    public void 檢查碰撞()
    {
        this.touched = collide_check.touched;
        this.誰碰到球 = collide_check.誰碰到球;
    }
    public void 殺球偵測()
    {
        if (this.touched && (this.誰碰到球 != "ground"))
        {
            this.殺球(this, this.誰碰到球, GameControl.Instance.new_player1, GameControl.Instance.new_player2);
        }
    }
}
