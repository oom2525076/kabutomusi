using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mato150 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("+150"); // ���O��\������
        kaunnto Kaunnto; //�ĂԃX�N���v�g�ɂ����Ȃ���
        GameObject obj = GameObject.Find("tokutenn"); //tokutenn���Ă����I�u�W�F�N�g��T��
        Kaunnto = obj.GetComponent<kaunnto>(); //�t���Ă���X�N���v�g���擾
        Kaunnto.tennsuu += 150;
    }
}
