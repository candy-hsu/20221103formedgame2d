﻿
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 生成子彈
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("子彈預製物")]
        private GameObject prefabShoot;
        
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        

        protected void SpawnBullet()
        {
            Instantiate(prefabShoot, pointSpawn.position, pointSpawn.rotation);
           
        }
    }

}
