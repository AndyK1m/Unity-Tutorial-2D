using UnityEngine;

public class Movement : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 10f;
    //void Start()
    //유니티 에디터를 실행하면 1번만 실행되는 함수
    //{
        //this.transform.position = this.transform.position + Vector3.forward;
        // 현재위치 = 현재위치 + (0,0,1)
        // this 는 스크립트가 들어간 객체를 이야기함 즉 Amongus Charater 임
    //}

    // Update is called once per frame
    void Update()
    // 매 프레임마다 실행
    {
        //this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        //this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        // A += B 
        // A + A + B
        // 이방법은 Input System 으로 되게 오래된 방법임 잘 안씀
        if (Input.GetKey(KeyCode.W)) //getkey = 한번만 getkeydown = 누르면 유지
        {
            transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * (moveSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * (moveSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
        }
    }
}
