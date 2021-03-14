using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getpoints : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject points;
    void Start()
    {
        //GameObject
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {
            GameObject.Find("point holder").GetComponent<pointmanager>().points++;
            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
