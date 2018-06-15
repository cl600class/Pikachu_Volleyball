using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiwinnie : player1 {
    public xiwinnie()
    {
        this.name = "習維尼";
        this.最大水平速度 = 5f;
        this.水平推力 = 48f;
        this.垂直推力 = 1250f;
        this.水平方向 = 1f;
         this.距離 = 0.1f;
        this.反彈力 = 100f;
        this.玩家 = GetComponent<Rigidbody2D>();

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
