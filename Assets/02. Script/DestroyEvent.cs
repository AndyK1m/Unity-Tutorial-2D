using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime); // 자기자신을 파괴하는 기능
    }

    void OnDestroy()
    {
        Debug.Log($"헉 {this.gameObject.name} 이거 부셔짐 ㅋㅋ");
    }

}
