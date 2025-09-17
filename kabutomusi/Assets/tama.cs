using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tama : MonoBehaviour
{
   
    

    // Start is called before the first frame update
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject);
    }
    void Start()
    {
     Generator Kouzyou; //呼ぶスクリプトにあだなつける
     GameObject obj = GameObject.Find("generator"); //generatorっていうオブジェクトを探す
     Kouzyou = obj.GetComponent<Generator>(); //付いているスクリプトを取得
       
        Application.targetFrameRate = 60;
        Shoot(new Vector3(Kouzyou.x, Kouzyou.y, Kouzyou.z));

    }

    // Update is called once per frame
    void Update()
    {
    

    }

}
