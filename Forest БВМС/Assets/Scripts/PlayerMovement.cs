using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    bool nearInteractable = false;
    public bool isInMiniGame = false;
    string lastCollide = "";


    /* void OnTriggerEnter2D(Collider2D collider)
    {
        lastCollide = collider.gameObject.tag;
        switch (collider.gameObject.tag)
        {
            case "FirePlace":
                collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                nearInteractable = true;
                // add fire making button and function and menu here
                break;

        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "FirePlace":
                collider.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                nearInteractable = false;
                break;
        }

    } */


    Animator anim;

    [SerializeField]
    float panSpeed = 2f;
    float lastpressed = 0;

    Vector2 pos;
    Vector2 movement_vector = new Vector2(0, 0);

    void Start()
    {
        //rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void QuitMiniGame()
    {
        isInMiniGame = false;
    }

    void Update()
    {

        pos = transform.position;
        movement_vector = new Vector2(0, 0);

       /*  if (Input.GetKeyDown("f") && nearInteractable)
        {
            if (lastCollide == "FirePlace")
            {
                Debug.Log("build fire menu");
				isInMiniGame = true;
            }

        } */

        if (!isInMiniGame)
        {
            if (Input.GetKey("w"))
            {
                anim.SetBool("iswalking", true);
                pos.y += panSpeed * Time.deltaTime;
                movement_vector.y = panSpeed * Time.deltaTime;
                anim.SetFloat("input_y", 1);
                anim.SetFloat("input_x", 0);
                lastpressed = 0;
            }
            else if (Input.GetKey("s"))
            {
                anim.SetBool("iswalking", true);
                pos.y -= panSpeed * Time.deltaTime;
                movement_vector.y = panSpeed * Time.deltaTime;
                anim.SetFloat("input_y", -1);
                anim.SetFloat("input_x", 0);
                lastpressed = 1;
            }
            else if (Input.GetKey("d"))
            {
                anim.SetBool("iswalking", true);
                pos.x += panSpeed * Time.deltaTime;
                movement_vector.x = panSpeed;//* Time.deltaTime;
                anim.SetFloat("input_x", 1);
                anim.SetFloat("input_y", 0);
                lastpressed = 2;
            }
            else if (Input.GetKey("a"))
            {
                anim.SetBool("iswalking", true);
                pos.x -= panSpeed * Time.deltaTime;
                movement_vector.x = panSpeed * Time.deltaTime;
                anim.SetFloat("input_x", -1);
                anim.SetFloat("input_y", 0);
                lastpressed = 3;
            }
            else
            {
                if (lastpressed == 0)
                {
                    anim.SetFloat("input_y", 1);
                    anim.SetFloat("input_x", 0);
                }
                else if (lastpressed == 1)
                {
                    anim.SetFloat("input_y", -1);
                    anim.SetFloat("input_x", 0);
                }
                else if (lastpressed == 2)
                {
                    anim.SetFloat("input_y", 0);
                    anim.SetFloat("input_x", 1);
                }
                else if (lastpressed == 3)
                {
                    anim.SetFloat("input_y", 0);
                    anim.SetFloat("input_x", -1);
                }
                anim.SetBool("iswalking", false);
            }
            if (!isInMiniGame)
            {
                transform.position = pos;
            }


        }
    }

}