using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class Player1 : Player{

        public Player1()
        {
            this.左鍵 = KeyCode.A;
            this.右鍵 = KeyCode.D;
            this.跳鍵 = KeyCode.W;
            this.下鍵 = KeyCode.S;
            this.加速及殺球鍵 = KeyCode.Space;
        }

        public void 移動(int s)
        {
            base.移動();
        }
    }
}

