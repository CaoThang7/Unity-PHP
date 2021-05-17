using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Namdidongdoc : MonoBehaviour
{
    private Rigidbody2D cnv;
    private bool isBottom = false;
    public float kc = 0f;
    // Start is called before the first frame update
    void Start()
    {
        cnv = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isBottom == true)
        {
            kc = 2f;
        }
        else
        {
            kc = -2;
        }
        cnv.velocity = new Vector2(0, transform.localScale.y) * kc;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if(collision.gameObject.tag == "conliderNam")
        {
            isBottom = true;
        }
        else
        {
            isBottom = false;
        }

    
    }


}
