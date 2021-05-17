using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VachamDinh : MonoBehaviour
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
        cnv.velocity = new Vector2(transform.localScale.x,0) * kc;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "vachamtrai")
        {
            isBottom = true;
        }
        else
        {
            isBottom = false;
        }
    }



}
