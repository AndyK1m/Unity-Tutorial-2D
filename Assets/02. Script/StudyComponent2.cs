using UnityEngine;

public class StudyComponent2 : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat; // 퍼블릭 쓰는 이유는 유니티 상에서 직접 넣는 경우이기 때문
    void Start()
    {
        CreateCube();
    }

    public void CreateCube()
    {
        //obj = new GameObject();
        //obj.name = "CUBE"
        // 를 줄여서 아래로 적음
        obj = new GameObject("CUBE");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        
        obj.AddComponent<BoxCollider>();
    }

}
