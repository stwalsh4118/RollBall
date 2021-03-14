using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpointcubes : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pointcube;
    float time = 0;
    float spawnRate = 2f;
    void Start()
    {
        time += Random.Range(0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {

        if(time>=spawnRate)
        {
            if (!GameObject.Find("Cube"))
            {
                GameObject.Instantiate(pointcube, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), Quaternion.identity);
                time = 0;
            }
        }
        time += Time.deltaTime;
    }
}
