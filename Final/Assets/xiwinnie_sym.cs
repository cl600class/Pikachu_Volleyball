﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class Xiwinnie_sym : Player2
    {
        public Xiwinnie_sym()
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
}