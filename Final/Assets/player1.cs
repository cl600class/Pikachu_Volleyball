using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour ,IMoveable{

    public float 最大水平速度;
    public float 水平推力;
    public float 垂直推力;
    public float 水平速度;
    public float 水平方向;
    public float 垂直速度;
    public Rigidbody2D 玩家;
    public bool grounded;
    public Transform groundCheck;
    public float 距離;
    public LayerMask groundLayer;

    // Use this for initialization
    void Start()
    {
        最大水平速度 = 10f;
        水平推力 = 60f;
        垂直推力 = 1250f;
        距離 = 0.1f;
        玩家 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        移動();
    }
    public void 移動()
    {
        水平速度 = Mathf.Clamp(玩家.velocity.x, -最大水平速度, 最大水平速度);
        水平方向 = Input.GetAxis("Horizontal");
        垂直速度 = 玩家.velocity.y;
        玩家.velocity = new Vector2(水平速度, 垂直速度);
        玩家.AddForce(new Vector2(水平推力 *水平方向, 0));
        if (是地板 && 跳)
        {
            玩家.AddForce(Vector2.up * 垂直推力);
        }
    }

    bool 是地板
    {
        get
        {
            Vector2 start = groundCheck.position;
            Vector2 end = new Vector2(start.x, start.y - 距離);
            Debug.DrawLine(start, end, Color.blue);
            grounded = Physics2D.Linecast(start, end, groundLayer);
            return grounded;
        }
    }
    public bool 跳
    {
        get
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}
