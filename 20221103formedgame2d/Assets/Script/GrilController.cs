
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 玩家控制器
    /// </summary>
    public class GrilController : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;

        [Header("圖片")]
        [SerializeField]
        private AnimationClip stop;
        [SerializeField]
        private AnimationClip girlaim;


        [SerializeField, Header("動畫元件")]
        private Animator ainma;

        int HeartNum = 3;
        [SerializeField, Header("血量")]
        private GameObject Heart01;
        [SerializeField]
        private GameObject Heart02;
        [SerializeField]
        private GameObject Heart03;

        [SerializeField]
        private string namef;
        [SerializeField]
        private GameObject s2;



        private void Update()
        {
            float v = Input.GetAxis("Vertical");

            float h = Input.GetAxis("Horizontal");

            transform.Translate(speedHorizontal * Time.deltaTime * h, speedVertical * Time.deltaTime * v, 0);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.gameObject.name == "namef")

            {

                Destroy(collision.gameObject);

                HeartNum = HeartNum - 1;



                //根據愛心數量，顯示愛心圖案

                if (HeartNum == 2) //如果還有兩顆愛心

                {

                    //讓第一顆愛心隱藏

                    Heart01.SetActive(false);

                }

                else if (HeartNum == 1) //如果還有一顆愛心

                {

                    //讓第二顆愛心隱藏

                    Heart02.SetActive(false);

                }

                else if (HeartNum == 0) //如果沒有愛心

                {

                    //讓第三顆愛心隱藏

                    Heart03.SetActive(false);

                }

            }
        }
    }


}


