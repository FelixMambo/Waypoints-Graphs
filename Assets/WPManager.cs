using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link{
    public enum direction { UNI, BI }
    public GameObject node1;
    public GameObject nude2;
    public direction dir;
}

public class WPManager : MonoBehaviour
{
    public GameObject[] waypoints;
    public Link[] links;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
