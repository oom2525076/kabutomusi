using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato150 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("+150"); // ログを表示する
        kaunnto Kaunnto; //呼ぶスクリプトにあだなつける
        GameObject obj = GameObject.Find("tokutenn"); //tokutennっていうオブジェクトを探す
        Kaunnto = obj.GetComponent<kaunnto>(); //付いているスクリプトを取得
        Kaunnto.tennsuu += 150;
    }
}
