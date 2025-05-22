using System;
using UnityEngine;

public class StudyGameobject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;
    
    public Vector3 pos;
    public Quaternion rot;

    void Start()
    {
        CreateAmongus();
        Debug.Log("만들어짐ㅋㅋ");
        
        Destroy(destroyObj, 3f); //매게변수로 들어간 오브젝트를 파괴하는 기능
    }

    void OnDestroy()
    {
        Debug.Log("다 부셔짐ㅋㅋ");
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, pos, rot); // 게임오브젝트를 생성하는 기능
        obj.name = "James";
    }
}