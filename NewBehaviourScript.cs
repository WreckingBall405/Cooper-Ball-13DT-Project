using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    //Makes it do you can change the values from unity
    public float turnspeed = 50;
    public float speed = 10;
    float h = Input.GetAxisRaw("Horizontal");
    float v = Input.GetAxisRaw("Vertical");


    // Update is called once per frame
    void Update()
    {
        //The movement controls
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (Input.GetKey("up"))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);

            if (Input.GetKey("right"))
            {
                transform.Rotate(0f, turnspeed * Time.deltaTime, 0f);
            }
            else if (Input.GetKey("left"))
            {
                transform.Rotate(0f, -turnspeed * Time.deltaTime, 0f);
            }
        }
        else if (Input.GetKey("down"))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
            if (Input.GetKey("right"))
            {
                transform.Rotate(0f, turnspeed * Time.deltaTime, 0f);
            }
            else if (Input.GetKey("left"))
            {
                transform.Rotate(0f, -turnspeed * Time.deltaTime, 0f);
            }
        }
        else if (Input.GetKey("r"))
        {
            //relodes the scene for a restart button
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
