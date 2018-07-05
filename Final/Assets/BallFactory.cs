using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
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
    }
}

