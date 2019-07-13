using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk : MonoBehaviour
{
    public float speed;

   
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        playermovment();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 15;
        }
        else
        {
            speed = 5;
        }
        movement += Vector3.forward * speed * Time.deltaTime;

    }


    void playermovment()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playermovment = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
        transform.Translate(playermovment, Space.Self);
    }

}
