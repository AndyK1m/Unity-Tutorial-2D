using UnityEngine;

namespace _02._Script
{
    public class Bullet : MonoBehaviour
    {
        public float bulletSpeed = 100f;
        public float destroyTime = 1.5f;
        void Update()
        {
            //transform.position += Vector3.forward * (bulletSpeed * Time.deltaTime);
            //                     월드상의 정면
            transform.position += transform.up * (bulletSpeed * Time.deltaTime);
            //                      자기자신의 정면
        
            Destroy(this.gameObject, destroyTime);
        }
    }
}
