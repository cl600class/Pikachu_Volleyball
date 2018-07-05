using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Core
{
    public class PokemonBall : Ball {

        public PokemonBall()
        {
            this.最小速度 = 10.5f;
            this.最大速度 = 18f;
        }

        public override void 移動()
        {
            this.水平位置 = this.球.position.x;
            this.目前水平速度 = this.球.velocity.x;
            this.目前垂直速度 = this.球.velocity.y;
            this.目前速率 = this.球.velocity.magnitude;
            this.目前速度 = this.球.velocity.normalized;
            this.調整後速率 = Mathf.Clamp(this.目前速率, this.最小速度, this.最大速度);
            this.調整後速度 = this.目前速度 * this.調整後速率;
            this.球.velocity = this.調整後速度;
        }
    }
}