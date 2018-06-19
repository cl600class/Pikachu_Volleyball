using Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : player{

    public player2()
    {
    this.左鍵 = KeyCode.LeftArrow;
    this.右鍵 = KeyCode.RightArrow;
    this.跳鍵 = KeyCode.UpArrow;
    this.下鍵 = KeyCode.DownArrow;
    this.加速及殺球鍵 = KeyCode.Comma;
    }
}
