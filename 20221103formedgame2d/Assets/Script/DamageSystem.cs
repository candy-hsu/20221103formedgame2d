
using UnityEngine;
namespace Uzai
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField]
        private string nameTarget2;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            if (collision.gameObject.name.Contains(nameTarget2))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}

