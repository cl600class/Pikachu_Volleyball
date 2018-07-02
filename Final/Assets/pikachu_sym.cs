using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu_sym : Player2{
    public Pikachu_sym()
    {
        this.名字 = "皮卡丘";
        this.最大水平速度 = 10f;
        this.水平推力 = 55f;
        this.垂直推力 = 1250f;
        this.水平方向 = 1f;
         this.距離 = 0.1f;
        this.反彈力 = 110f;
        this.前端位移 = 0.9f;
    }
}
