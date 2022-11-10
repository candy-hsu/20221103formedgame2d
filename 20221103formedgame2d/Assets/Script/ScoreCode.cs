using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.UI;

namespace Uzai
{
    public class ScoreCode : MonoBehaviour
    {
        //宣告分數參數

        public static int Score;
            //宣告文字UI

        public Text ShowScore;

        void Update()

        {

            //讓UI文字與分數同步

            ShowScore.text = Score.ToString();

        }
    }
}

