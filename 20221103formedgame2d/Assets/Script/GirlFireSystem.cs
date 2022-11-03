
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 玩家射擊
    /// </summary>
    public class GirlFireSystem : FireSystem
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnBullet();
            }
        }

    }
}

