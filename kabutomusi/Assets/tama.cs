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
     Generator Kouzyou; //�ĂԃX�N���v�g�ɂ����Ȃ���
     GameObject obj = GameObject.Find("generator"); //generator���Ă����I�u�W�F�N�g��T��
     Kouzyou = obj.GetComponent<Generator>(); //�t���Ă���X�N���v�g���擾
       
        Application.targetFrameRate = 60;
        Shoot(new Vector3(Kouzyou.x, Kouzyou.y, Kouzyou.z));

    }

    // Update is called once per frame
    void Update()
    {
    

    }

}
