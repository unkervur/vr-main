using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* � ���� ������� � ������� addscr2 ��, �������� �� 3 ��������. ����� ��� �������������� � ����� ������ ��� ����, 
 * � ��� y=100 ����� ���������.*/ 

public class script2 : MonoBehaviour
{
    static public int r, g, b;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }

    public void OnTriggerStay(Collider other)
    {
        r = Random.Range(0, 255);
        g = Random.Range(0, 255);
        b = Random.Range(0, 255);

        this.GetComponent<Renderer>().material.color = new Color32((byte)r, (byte)g, (byte)b, 3);

    }
}
