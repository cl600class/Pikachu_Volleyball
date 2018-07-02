using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xiwinnie : Player1 {
    public Xiwinnie()
    {
        this.名字 = "習維尼";
        this.最大水平速度 = 8f;
        this.水平推力 = 60f;
        this.垂直推力 = 1250f;
        this.水平方向 = 1f;
         this.距離 = 0.1f;
        this.反彈力 = 115f;
        this.前端位移 = 0.55f;
    }
}
