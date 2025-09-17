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
    }
    void Start()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 1000));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
