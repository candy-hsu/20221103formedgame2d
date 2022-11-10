
using UnityEngine;
namespace Uzai
{
    public class FireGSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabShoot;
        [SerializeField]
        private GameObject prefabShoot2;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField]
        private Transform pointSpawn2;

        protected void SpawnBullet()
        {
            Instantiate(prefabShoot, pointSpawn.position, pointSpawn.rotation);
            Instantiate(prefabShoot2, pointSpawn2.position, pointSpawn2.rotation);
        }
    }
}

