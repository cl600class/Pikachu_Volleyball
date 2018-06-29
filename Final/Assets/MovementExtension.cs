using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public static class MovementExtension{

    public static void 殺球(this IMoveable 可移動的, Ball 目標球, string 誰碰到球, player1 player1, player2 player2)
    {
        Vector2 方向;
        Vector2 上殺球;
        Vector2 平殺球;
        Vector2 下殺球;
        float 殺球力 = 40f;
        player player;
        if (誰碰到球 == "player1")
        {
            player = player1;
            方向 = Vector2.right;
            平殺球 = 方向;
            上殺球 = Rotate(方向, 30);
            下殺球 = Rotate(方向, -30);
        }
        else
        {
            player = player2;
            方向 = Vector2.left;
            平殺球 = 方向;
            上殺球 = Rotate(方向, -30);
            下殺球 = Rotate(方向, 30);
        }
        目標球.最大速度 = GameControl.Instance.排球預設最大速度;
        if ((!(player.是地板)) && Input.GetKey(player.加速及殺球鍵))
        {
            目標球.最大速度 = 24f;
            if (Input.GetKey(player.右鍵) || Input.GetKey(player.左鍵))
                目標球.球.AddForce(殺球力 * 平殺球);
            else if (Input.GetKey(player.跳鍵))
                目標球.球.AddForce(殺球力 * 上殺球);
            else if (Input.GetKey(player.下鍵))
                目標球.球.AddForce(殺球力 * 下殺球);
        }
    }

    private static Vector2 Rotate(Vector2 要旋轉的向量, float 要旋轉的角度)
    {
        float 角度 = 要旋轉的角度 * Mathf.Deg2Rad;
        float sin角度 = Mathf.Sin(角度);
        float cos角度 = Mathf.Cos(角度);
        float 新的x向量 = cos角度 * 要旋轉的向量.x - sin角度 * 要旋轉的向量.y;
        float 新的y向量 = sin角度 * 要旋轉的向量.x + cos角度 * 要旋轉的向量.y;
        return new Vector2(新的x向量, 新的y向量);
    }
}
