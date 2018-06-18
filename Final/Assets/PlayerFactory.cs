using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core;

public class PlayerFactory : MonoBehaviour {
    private static GameObject Load_from_Resources(string player_name)
    {
        return Resources.Load(player_name) as GameObject;
    }
    public static GameObject Create_player1_obj(int charctorNo)
    {
        switch (charctorNo)
        {
            case 1:
                return Load_from_Resources("pikachu");
            case 2:
                return Load_from_Resources("xiwinnie");
            default:
                return Load_from_Resources("pikachu");
        }
    }

   public static GameObject Create_player2_obj(int charactorNo)
    {
        switch (charactorNo)
        {
            case 1:
                return Load_from_Resources("pikachu_sym");
            default:
                return Load_from_Resources("pikachu_sym");
        }
    }
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
