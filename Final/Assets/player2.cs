using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class Player2 : Player{

        public Player2()
        {
        this.左鍵 = KeyCode.LeftArrow;
        this.右鍵 = KeyCode.RightArrow;
        this.跳鍵 = KeyCode.UpArrow;
        this.下鍵 = KeyCode.DownArrow;
        this.加速及殺球鍵 = KeyCode.Comma;
        }

        //可加入自動移動
        public void 移動(int s)
        {
            base.移動();
        }
    }
}