
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Uzai
{
    public class ConcusSciene : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("start");
        }
        public void HowToPlay()
        {
            SceneManager.LoadScene("start 2");
        }
        public void GameStart()
        {
            SceneManager.LoadScene("CircusGame 1");
        }
    }

}
