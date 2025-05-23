using UnityEngine;

public class StudyLookAtCamera : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    
    void Start() // 세팅하는 기능 무엇인가를 세팅하는 기능
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }
    void Update() // 무언가를 바라보는 기능
    {
        turretHead.LookAt(targetTf);
    }
}
