using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato100 : MonoBehaviour
{
    //Start is called before the first frame update


    // 当たった時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("+100"); // ログを表示する
        kaunnto Kaunnto; //呼ぶスクリプトにあだなつける
        GameObject obj = GameObject.Find("tokutenn"); //tokutennっていうオブジェクトを探す
        Kaunnto = obj.GetComponent<kaunnto>(); //付いているスクリプトを取得
        Kaunnto.tennsuu += 100;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
       
     
    }
}
//PlayerScript playerscript; //呼ぶスクリプトにあだなつける
//GameObject obj = GameObject.Find("Player"); //Playerっていうオブジェクトを探す
//playerscript = obj.GetComponent<PlayerScript>(); //付いているスクリプトを取得
//playerscript.speed = 10;