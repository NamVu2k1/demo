using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorControler : MonoBehaviour
{
    private Animator m_animator;
    private Rigidbody2D m_body2d;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_animator.SetFloat("Velocity.Y", m_body2d.velocity.y);
        if (Input.GetKeyDown("space"))
        {
            m_body2d.velocity = new Vector2(0,9);
            m_animator.SetTrigger("Jump");
        }
        else if(Input.GetKey("d"))
        {
            m_animator.SetTrigger("Run");
            m_body2d.velocity = new Vector2(2, 0);
        }
    }
}
