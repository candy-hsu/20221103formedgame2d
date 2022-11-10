
using UnityEngine;
namespace Uzai
{
    public class CoinCode : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.name == "girl")
            {
                ScoreCode.Score = ScoreCode.Score + 1;
            }
        }
    }
}

