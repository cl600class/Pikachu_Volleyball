using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class PlayerFactory : MonoBehaviour {
    public static GameObject 皮卡丘 { get; private set; }

    public static player1 Create_player1(int charctorNo)
    {
        switch (charctorNo)
        {
            case 1:
                return new pikachu();
            case 2:
                return new xiwinnie();
            default:
                return new pikachu();
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
