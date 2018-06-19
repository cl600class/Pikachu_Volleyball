using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class player : MonoBehaviour, IMoveable {
    public string 名字;
    public float 最大水平速度;
    public float 水平推力;
    public float 垂直推力;
    public float 水平速度;
    public float 水平方向;
    public float 垂直速度;
    public Rigidbody2D 玩家;
    public float 距離;
    public bool grounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float 反彈力;
    public float 前端位移;
    public KeyCode 左鍵;
    public KeyCode 右鍵;
    public KeyCode 跳鍵;
    public KeyCode 下鍵;
    public KeyCode 加速及殺球鍵;

    public void 移動()
    {
        this.水平速度 = this.玩家.velocity.x;
        if (!(是地板 && Input.GetKey(加速及殺球鍵)))
            this.水平速度 = Mathf.Clamp(this.水平速度, -this.最大水平速度, this.最大水平速度);
        this.水平方向 = GetDirection(Input.GetKey(this.右鍵), Input.GetKey(this.左鍵));
        this.垂直速度 = this.玩家.velocity.y;
        反彈(this.玩家);
        this.玩家.velocity = new Vector2(this.水平速度, this.垂直速度);
        this.玩家.AddForce(new Vector2(this.水平推力 * this.水平方向, 0));
        if (是地板 && 跳)
        {
            this.玩家.AddForce(Vector2.up * this.垂直推力);
        }
    }

    private float GetDirection(bool key_right, bool key_left)
    {
        if (key_right && !key_left)
            return 1f;
        else if (key_left && !key_right)
            return -1f;
        else
            return 0f;
    }

    private bool 是地板
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

    private bool 跳
    {
        get
        {
            return Input.GetKeyDown(this.跳鍵);
        }
    }

    private void 反彈(Rigidbody2D 目標)
    {
        if (目標.tag == "player1")
        {
            if (this.玩家.position.x + this.前端位移 > -0.2f)
                this.玩家.AddForce(new Vector2(-this.反彈力, 0));
        }
        else if (目標.tag == "player2")
        {
            if (this.玩家.position.x - this.前端位移 < 0.28f)
                this.玩家.AddForce(new Vector2(this.反彈力, 0));
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}