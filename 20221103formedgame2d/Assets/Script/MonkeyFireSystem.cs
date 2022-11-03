
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 敵人射擊
    /// </summary>
    public class MonkeyFireSystem : FireSystem
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}

