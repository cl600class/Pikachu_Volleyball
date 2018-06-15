using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour ,IMoveable{

    public string name;
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
    public float 反彈力;
    public float 前端位移;

    // Use this for initialization
    void Start()
    {
       /* 最大水平速度 = 10f;
        水平推力 = 48f;
        垂直推力 = 1250f;
        距離 = 0.1f;
        玩家 = GetComponent<Rigidbody2D>();*/
    }

    // Update is called once per frame
    void Update()
    {
        //移動();
    }
    public Rigidbody2D Initialize()
    {
        return this.玩家;
    }

    public void 移動()
    {
        this.水平速度 = Mathf.Clamp(this.玩家.velocity.x, -this.最大水平速度, this.最大水平速度);
        //水平方向 = Input.GetAxis("Horizontal");
        this.水平方向 = GetDirection(Input.GetKey(KeyCode.D), Input.GetKey(KeyCode.A));
        this.垂直速度 = this.玩家.velocity.y;
        if (this.玩家.position.x + this.前端位移 > -0.2f)
        {
            this.玩家.AddForce(new Vector2(-this.反彈力, 0));
        }
        this.玩家.velocity = new Vector2(this.水平速度, this.垂直速度);
        this.玩家.AddForce(new Vector2(this.水平推力 * this.水平方向, 0));
        if (是地板 && 跳)
        {
            this.玩家.AddForce(Vector2.up * this.垂直推力);
        }
    }
    private float GetDirection( bool key_right, bool key_left)
    {
        if (key_right && !key_left)
            return 1f;
        else if (key_left && !key_right)
            return -1f;
        else
            return 0f;
    }
    bool 是地板
    {
        get
        {
            Vector2 start = this.groundCheck.position;
            Vector2 end = new Vector2(start.x, start.y - this.距離);
            Debug.DrawLine(start, end, Color.blue);
            this.grounded = Physics2D.Linecast(start, end, this.groundLayer);
            return this.grounded;
        }
    }
    public bool 跳
    {
        get
        {
            return Input.GetKeyDown(KeyCode.W);
        }
    }
}
