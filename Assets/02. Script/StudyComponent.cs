using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj; // 큐브 게임오브젝트를 가져오고 싶음

    public Transform objTf;

    public string changeName;
    void Start()
    {
        // obj = GameObject.Find("Main Camera");
        // obj.name = changeName;
        
        obj = GameObject.FindGameObjectWithTag("Player");
        
        objTf = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log($"이름 : {obj.name}"); //게임 오브젝트의 이름을 출력
        Debug.Log($"태그 : {obj.tag}");
        Debug.Log($"위치 : {obj.transform.position}"); // 위치
        Debug.Log($"회전 : {obj.transform.rotation}"); // 회전
        Debug.Log($"크기 : {obj.transform.localScale}"); //크기
        
        Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Meterial 데이터 : {obj.GetComponent<MeshRenderer>().material}");
        
        obj.GetComponent<MeshRenderer>().enabled = false;
        
        //obj 의 Gameobject 의 활성상태를 끄는기능 false
        obj.SetActive(false);
        objTf.gameObject.SetActive(false);
    }

}
