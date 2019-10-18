using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxToFall : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;

    void Start()
    {
        //cube.GetComponent<Rigidbody>().isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        cube.GetComponent<Rigidbody>().isKinematic = false;
    }
}
