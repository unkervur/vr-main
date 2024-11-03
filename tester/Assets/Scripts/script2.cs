using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// В этом скрипте ДЗ, заданное на 3 семинар.

public class script2 : MonoBehaviour
{
    public int r, g, b;
    public int x = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void button()
    {
        r = Random.Range(0, 255);
        g = Random.Range(0, 255);
        b = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)r, (byte)g, (byte)b, 3);
    }
}
