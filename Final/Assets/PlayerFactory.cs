using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class PlayerFactory : MonoBehaviour {

    /*public static player1 Create_player1(int charctorNo)
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
    }*/
    public static GameObject Create_player1_obj(int charctorNo)
    {
        switch (charctorNo)
        {
            case 1:
                return Resources.Load("pikachu") as GameObject;
            case 2:
                return Resources.Load("xiwinnie") as GameObject;
            default:
                return Resources.Load("pikachu") as GameObject;
        }
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
