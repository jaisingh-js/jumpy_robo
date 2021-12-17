using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_platform : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed = 3f;
    private Vector3 nextpos;
    public Transform start_pos;
    void Start()
    {
        nextpos = start_pos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextpos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextpos = pos1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextpos, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.transform.parent = this.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
}
