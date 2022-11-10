using System.Collections;

using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

namespace Uzai
{
    public class ScoreCode : MonoBehaviour
    {
        //宣告分數參數

        public static int Score;
        //宣告文字UI
        [SerializeField,Header("碰到會計分的名稱")]
        private string nameTarget;

        public TextMeshProUGUI ShowScore;

        void Update()

        {

            //讓UI文字與分數同步

            ShowScore.text = Score.ToString();

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                ScoreCode.Score += 1;
                print(Score);

            }
        }
        

           
        
    }
}

