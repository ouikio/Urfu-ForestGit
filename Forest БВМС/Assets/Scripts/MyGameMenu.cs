using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameMenu : MonoBehaviour
{
    bool playerNearMe = false;
    string lastCollide = "";
    [SerializeField]
    GameObject myMiniGame;
    [SerializeField]
    GameObject player;

     void OnTriggerEnter2D(Collider2D collider)
    {
        lastCollide = collider.gameObject.tag;
        switch (collider.gameObject.tag)
        {
            case "Player":
                this.transform.GetChild(0).gameObject.SetActive(true);
                playerNearMe = true;
                // add fire making button and function and menu here
                break;

        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Player":
                this.transform.GetChild(0).gameObject.SetActive(false);
                playerNearMe = false;
                break;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown("f") && playerNearMe)
        {
            myMiniGame.SetActive(true);
            player.GetComponent<PlayerMovement>().isInMiniGame = true;
        }
        
    }
}
