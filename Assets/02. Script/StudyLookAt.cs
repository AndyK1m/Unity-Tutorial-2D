using UnityEngine;

namespace _02._Script
{
    public class StudyLookAt : MonoBehaviour
    {
        public Transform targetTf;
        public Transform turretHead;
    
        public GameObject bulletPrefab;
        public Transform firePos;

        public float timer;
        public float cooldownTime;
    
        void Start() // 세팅하는 기능 무엇인가를 세팅하는 기능
        {
            targetTf = GameObject.FindGameObjectWithTag("Player").transform;
        }
        void Update() // 무언가를 바라보는 기능
        {
            turretHead.LookAt(targetTf);
        
            timer += Time.deltaTime;
            if (timer >= cooldownTime)
            {
                timer = 0f;
                Instantiate(bulletPrefab, firePos.position, firePos.rotation);
            }
        }
    }
}
