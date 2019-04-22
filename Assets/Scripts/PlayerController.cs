using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector2 finalPos;

    public float moveY;
    public float speed;
    public int health = 3;

    public float verticalExtent;

    void Start()
    {
        //verticalExtent = Camera.main.orthographicSize ;
        //Debug.Log(verticalExtent);
    }

    void Update()
    {
      //  transform.position = Vector3.Lerp(transform.position, finalPos, 0.2f);
        transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < verticalExtent)
        {
            finalPos = new Vector2(transform.position.x, transform.position.y + moveY);
           
            //transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);
            Debug.Log(transform.position.y);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -verticalExtent)
        {
            finalPos = new Vector2(transform.position.x, transform.position.y - moveY);
           // transform.position = finalPos;
            //transform.position = Vector2.MoveTowards(transform.position, finalPos, speed * Time.deltaTime);
            // Debug.Log(transform.position.y);
        }
       

    }
}
