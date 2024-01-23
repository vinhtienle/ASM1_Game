using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{


    // Start is called before the first frame update
    public GameObject player;// nhân vật 
    public float start, end;// điểm bắt đầu và điểm kết thúc 
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        // vị trí nhân vật 
        var playrx = player.transform.position.x;

        // vị trí camera 

        var camx = transform.position.x;
        var camy = transform.position.y;
        var camz = transform.position.z;
        if (playrx > start && playrx < end)
        {
            camx = playrx;
        }
        else
        {
            if (playrx < start)
            {
                camx = start;

            }
            if (playrx > end)
            {
                camx = end;
            }
        }
        transform.position = new Vector3(camx,camy,camz);



    }
}
