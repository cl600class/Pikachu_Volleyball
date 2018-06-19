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
    public Vector2 調整後速度;
    public float 調整後速率;
    public const float 最小速度 = 8f;
    public const float 最大速度 = 18f;
    public static float 水平位置; 
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
        水平位置 = 球.position.x;
        移動();
	}

    public void 移動()
    {
        目前水平速度 = 球.velocity.x;
        目前垂直速度 = 球.velocity.y;
        目前速率 = 球.velocity.magnitude;
        目前速度 = 球.velocity.normalized;
        調整後速率 = Mathf.Clamp(目前速率, 最小速度, 最大速度);
        調整後速度 = 目前速度 * 調整後速率;
        球.velocity = 調整後速度;
    }
    public static float GetHorizontalPosition()
    {
        return 水平位置;
    }
}
