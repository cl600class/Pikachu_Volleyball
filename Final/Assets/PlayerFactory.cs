using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class PlayerFactory {

        public static string Create_player1_obj(int charctorNo)
        {
            switch (charctorNo)
            {
                case 1:
                    return "pikachu";
                case 2:
                    return "xiwinnie";
                default:
                    return "pikachu";
            }
        }

        public static string Create_player2_obj(int charactorNo)
        {
            switch (charactorNo)
            {
                case 1:
                    return "pikachu_sym";
                case 2:
                    return "xiwinnie_sym";
                default:
                    return "pikachu_sym";
            }
        }
    }
}