using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pikachu : player1{
    public pikachu()
    {
        this.name = "皮卡丘";
        this.最大水平速度 = 10f;
        this.水平推力 = 48f;
        this.垂直推力 = 1250f;
        //this.水平速度 = 0;
        this.水平方向 = 1f;
        //this.垂直速度 = 0;
         this.距離 = 0.1f;
        this.反彈力 = 110f;
        this.前端位移 = 0.9f;
        this.玩家 = GetComponent<Rigidbody2D>();
        //this.grounded = true;
        //this.groundCheck = groundCheck;

        //this.groundLayer = groundLayer;
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	}
    public void 移動()
    {
        水平速度 = Mathf.Clamp(玩家.velocity.x, -最大水平速度, 最大水平速度);
        //水平方向 = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.D)&&!Input.GetKey(KeyCode.A))
            水平方向 = 1f;
        else if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
            水平方向 = -1f;
        else
            水平方向 = 0f;
        垂直速度 = 玩家.velocity.y;
        if (玩家.position.x > -1.1f)
        {
            玩家.AddForce(new Vector2(-100f, 0));
        }
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
            return Input.GetKeyDown(KeyCode.W);
        }
    }
}
