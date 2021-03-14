using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointmanager : MonoBehaviour
{
    public int points = 0;
    public Text pointsText;
    void Start()
    {
        pointsText = GameObject.Find("ptext").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.text = points.ToString();
    }
}
