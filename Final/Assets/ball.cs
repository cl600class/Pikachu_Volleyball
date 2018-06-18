using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class ball : MonoBehaviour, IMoveable {
    public Rigidbody2D 球;
    public float 目前水平速度;
    public float 目前垂直速度;
    public Vector2 目前速度;
    public float 目前速率;
    public float 水平速度;
    public float 垂直速度;
    public const float 最小垂直速度 = 6f;
    public const float 最大垂直速度 = 18f;
    public Vector2 調整後速度;
    public float 調整後速率;
    public const float 最小速度 = 8f;
    public const float 最大速度 = 18f;
    public bool touched;
    public string 誰碰到球;
    // Use this for initialization
    void Start () {
        球 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        誰碰到球 = collide_check.誰碰到球;
        touched = collide_check.touched;
        移動();
	}

    public void 移動()
    {
        目前水平速度 = 球.velocity.x;
        目前垂直速度 = 球.velocity.y;
        //垂直速度 = Mathf.Clamp(Mathf.Abs(目前垂直速度), 最小垂直速度, 最大垂直速度);
        目前速率 = 球.velocity.magnitude;
        目前速度 = 球.velocity.normalized;
        調整後速率 = Mathf.Clamp(目前速率, 最小速度, 最大速度);
        調整後速度 = 目前速度 * 調整後速率;
        //水平速度 = Mathf.Clamp(目前水平速度, -最大水平速度, 最大水平速度);

        //if (目前垂直速度 < 0) 垂直速度 = -垂直速度;
        //else if (目前垂直速度 == 0) 垂直速度 = 0;
        球.velocity = 調整後速度;
    }
  
}
