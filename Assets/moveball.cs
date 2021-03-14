using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveball : MonoBehaviour
{
    float speed = 20f;
    Transform camera;
    float explosionForce = 200f;
    float baseAbilityTime = 2f;
    float abilityTimer = 0;
    public GameObject abilTimerHider;
    public Text abilTimeLeft;
    // Start is called before the first frame update
    public void Awake()
    {
        abilTimerHider.SetActive(false);
        camera = GameObject.Find("Main Camera").transform;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        abilityTimer += Time.deltaTime;
        abilTimeLeft.text = abilityTimer.ToString();
        if (abilityTimer >= baseAbilityTime)
        {
            abilTimerHider.SetActive(false);
        }
            if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.GetComponent<Rigidbody>().velocity = (new Vector3(0, 0, 0));
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, 500f, 0));
        }
        if(Input.GetKey(KeyCode.Q))
        {
            if (abilityTimer >= baseAbilityTime)
            {
                abilTimerHider.SetActive(true);
                foreach (GameObject cube in GameObject.FindGameObjectsWithTag("cube"))
                {
                    Vector3 d = cube.transform.position - transform.position;
                    Vector3.Normalize(d);
                    cube.transform.GetComponent<Rigidbody>().AddForce(d * explosionForce);
                }
                abilityTimer = 0;
            }
        }
        transform.rotation = camera.rotation;
        transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, transform.eulerAngles.z);
    }
}
