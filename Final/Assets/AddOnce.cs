using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

public class AddOnce : WordDecoration {

    public static string 想加入的文字;

    public AddOnce(DisplayWord 想裝飾的東西, string 加入文字)
    {
        被裝飾的元件 = 想裝飾的東西;
        想加入的文字 = 加入文字;
    }

    public override string 輸出文字(string 文字)
    {
        if (文字.Contains(想加入的文字))
            return 被裝飾的元件.輸出文字(文字);
        else
            return 被裝飾的元件.輸出文字(想加入的文字 + 文字);
    }
}
