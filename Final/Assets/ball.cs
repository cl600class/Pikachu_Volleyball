using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Ball : MonoBehaviour, IMoveable {
        public Rigidbody2D 球;
        public float 目前水平速度;
        public float 目前垂直速度;
        public Vector2 目前速度;
        public float 目前速率;
        public Vector2 調整後速度;
        public float 調整後速率;
        public float 最小速度;
        public float 最大速度;
        public float 水平位置;
        public bool touched;
        public string 誰碰到球;

        public virtual void 移動()
        {

        }

        public void 檢查碰撞()
        {
            this.touched = Collide_check.Instance.touched;
            this.誰碰到球 = Collide_check.Instance.誰碰到球;
        }

        public bool 檢查得分()
        {
            return Collide_check.Instance.得分&&(this.球.position.y<0);
        }
    }
}

