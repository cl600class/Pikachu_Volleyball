using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactory {
    public static string Create_ball(int ballNo)
    {
        switch (ballNo)
        {
            case 1:
                return "PokemonBall";
            default:
                return "PokemonBall";
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
