using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pikachu : player1{
    public pikachu()
    {
        this.名字 = "皮卡丘";
        this.最大水平速度 = 10f;
        this.水平推力 = 48f;
        this.垂直推力 = 1250f;
        this.水平方向 = 1f;
         this.距離 = 0.1f;
        this.反彈力 = 110f;
        this.前端位移 = 0.9f;
        //this.玩家 = GetComponent<Rigidbody2D>();
    }
}
