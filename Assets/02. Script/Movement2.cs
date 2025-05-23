using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public float moveSpeed = 500f;
    void Update()
    {
        // 부드럽게 증감하는 값
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        // 딱 떨어지는 값
        //float h = Input.GetAxisRaw("Horizontal");
        //float v = Input.GetAxisRaw("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        
        Vector3 normalDir = dir.normalized;
        
        Debug.Log($"현재 입력 : {normalDir}");
        
        transform.position += normalDir * (moveSpeed * Time.deltaTime);
        transform.LookAt(this.transform.position + normalDir);
    }
}
