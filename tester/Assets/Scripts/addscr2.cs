using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addscr2 : MonoBehaviour
{
    public int y = 0;
    public Text type;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void button()
    {
        script2.r = Random.Range(0, 255);
        script2.g = Random.Range(0, 255);
        script2.b = Random.Range(0, 255);
        this.GetComponent<Renderer>().material.color = new Color32((byte)script2.r, (byte)script2.g, (byte)script2.b, 3);

    }

    public void OnTriggerStay(Collider other)
    {
        ++y;
        type.text = y.ToString();

        if (y == 100)
        {
            sphere.gameObject.SetActive(false);
        }
    }
}
