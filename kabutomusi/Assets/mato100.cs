using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato100 : MonoBehaviour
{
    //Start is called before the first frame update


    // �����������ɌĂ΂��֐�
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("+100"); // ���O��\������
        kaunnto Kaunnto; //�ĂԃX�N���v�g�ɂ����Ȃ���
        GameObject obj = GameObject.Find("tokutenn"); //tokutenn���Ă����I�u�W�F�N�g��T��
        Kaunnto = obj.GetComponent<kaunnto>(); //�t���Ă���X�N���v�g���擾
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
//PlayerScript playerscript; //�ĂԃX�N���v�g�ɂ����Ȃ���
//GameObject obj = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
//playerscript = obj.GetComponent<PlayerScript>(); //�t���Ă���X�N���v�g���擾
//playerscript.speed = 10;