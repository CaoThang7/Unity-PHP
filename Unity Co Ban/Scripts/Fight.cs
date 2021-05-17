using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //va cham Nam
        if(collision.gameObject.tag == "nam_left")
        {
            Destroy(GameObject.Find("player_ini"));
        }
        if (collision.gameObject.tag == "nam_top")
        {
            Destroy(GameObject.Find("Nam"));
        }
        if (collision.gameObject.tag == "nam_right")
        {
            Destroy(GameObject.Find("player_ini"));
        }


        //va cham dinh
        if (collision.gameObject.tag == "dinh")
        {
            Destroy(GameObject.Find("player_ini"));
        }





    }
}
