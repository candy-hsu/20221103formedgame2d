
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

        

        private void Update()
        {
            float v = Input.GetAxis("Vertical");

            float h = Input.GetAxis("Horizontal");

            transform.Translate(speedHorizontal * Time.deltaTime * h, speedVertical * Time.deltaTime * v, 0);

            
            
        }

       
    }
}

