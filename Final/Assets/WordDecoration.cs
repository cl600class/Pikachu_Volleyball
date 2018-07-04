using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WordDecoration :  DisplayWord{

    public DisplayWord 被裝飾的元件;

    public DisplayWord 復原()
    {
        return 被裝飾的元件;
    }
}
