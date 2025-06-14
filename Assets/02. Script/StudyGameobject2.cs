using System;
using UnityEngine;

public class StudyGameobject2 : MonoBehaviour
{
    public GameObject prefab;
    //void Start() 여기는 세팅이긴 하지만 서브적인 부분이 들어감
    void Awake() // 이게 제일빠름 시스템의 주축이 되는 것들이 들어감
    {
        CreateAmongus();
    }
    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";
        
        Transform objTf = obj.transform;
        int count = objTf.childCount;
        
        //Debug.Log($"캐릭터의 자식 오브젝트 수 : {obj.transform.childCount}");
        //Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");
        //Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : +" +
        //          $"{obj.transform.GetChild(obj.transform.childCount - 1).name}");
        
        Debug.Log($"캐릭터의 자식 오브젝트 수 : {count}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : +{objTf.GetChild(count - 1).name}");
    }
}