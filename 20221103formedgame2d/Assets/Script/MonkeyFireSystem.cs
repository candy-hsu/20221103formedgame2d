
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
        [SerializeField, Header("時間"), Range(0, 30)]
        private float delaytime ;
        private float clock = 0;
        private bool isStart = false;
        private bool a = true;
    
        

        //private void Awake()
        //{
            //    InvokeRepeating("SpawnBullet", 0, interval );
        //}

        private void Update()
        {
            clock += Time.deltaTime;
            print(this.gameObject.name + "的時間為" + clock);
            if (clock > delaytime)
            {
                isStart = true;
                setStar();
                
            }
        }

        private void setStar()
        {
            
            if( isStart==true && a==true)
            {
                InvokeRepeating("SpawnBullet", 0, interval);
            }

            a = false;
        }



    }
}

