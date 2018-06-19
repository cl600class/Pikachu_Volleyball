using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : player{

    public player1()
    {
        this.左鍵 = KeyCode.A;
        this.右鍵 = KeyCode.D;
        this.跳鍵 = KeyCode.W;
        this.下鍵 = KeyCode.S;
        this.加速及殺球鍵 = KeyCode.Space;
    }
}
