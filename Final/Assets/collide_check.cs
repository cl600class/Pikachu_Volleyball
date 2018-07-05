using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class Collide_check : MonoBehaviour {

        public string 誰碰到球;
        public bool touched;
        public bool 得分;
        public static Collide_check Instance;    
        //public Player player;


        public void OnTriggerEnter2D(Collider2D Collision)
        {
            誰碰到球 = Collision.gameObject.tag;
            //player = Collision.gameObject.GetComponent<Player>();
            if (誰碰到球 == "player1" || 誰碰到球 == "player2" || 誰碰到球 == "ground")
            {
                touched = true;
                if (誰碰到球 == "ground")
                {
                    得分 = true;
                }
            }
            else
            {
                touched = false;
                得分 = false;
            }
        }
        public void OnTriggerExit2D(Collider2D collision)
        {
            StartCoroutine(延遲清空());
        }
        void Start()
        {
            Instance = this;
            誰碰到球 = null;
            得分 = false;
        }

        IEnumerator 延遲清空()
        {
            yield return new WaitForSecondsRealtime(0.2f);
            誰碰到球 = null;
            touched = false;
        }
    }
}

