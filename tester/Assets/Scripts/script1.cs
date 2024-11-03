using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*В этом скрипте ДЗ, заданное на втором семинаре. Скрипт привязывала к кубу Cube или плоскости Plane. Скрипт удаляет куб/плоскость,
 * когда x доходит до 100*/

public class script1 : MonoBehaviour
{
    public GameObject cube;
    public Text txt;
    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        x++;

        if (x >= 100)
        {
            this.gameObject.SetActive(false);
        }
        txt.text = x.ToString();
    }
}
