using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    bool movable;
    Rigidbody2D rigid;
    private void Awake()
    {
        movable = true;
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        movable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movable)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //rigid.AddForce(Vector2.left * rigid.mass * 100,ForceMode2D.Force);
                transform.Translate(Vector2.left * 0.1f, Space.World);
                Debug.Log("LeftArrow");
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                //rigid.AddForce(Vector2.right * rigid.mass * 100, ForceMode2D.Force);
                transform.Translate(Vector2.right * 0.1f, Space.World);
                Debug.Log("RightArrow");
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigid.AddForce(Vector2.up * rigid.mass * Physics2D.gravity*-1*10, ForceMode2D.Force);
                Debug.Log("Space");
            }
        }
    }
}
