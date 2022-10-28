using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbody : MonoBehaviour
{
    private Vector2 velocity;
    private Rigidbody2D rb2D;
    public Collider2D col2D;
    private List<ContactPoint2D> contactPoints = new List<ContactPoint2D>();
    void Start()
    {
        velocity = new Vector2(1.75f, 1.1f);
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        //col2D = gameObject.GetComponent<Collider2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    private void FixedUpdate()
    {
       // rb2D.AddForce(transform.up *8f);
        //rb2D.AddForceAtPosition(new Vector3(0, 0.1f, 0), new Vector3(1, 0, 0));

        //Debug.Log(rb2D.ClosestPoint(new Vector3(0, 0, 0)));
        // Debug.Log(rb2D.Distance(col2D).distance);  // khoang cac giua rigid chứa collider vs collider chỉ định
       
       // Debug.Log(rb2D.IsTouching(col2D));
        
       
        Debug.Log(rb2D.IsTouchingLayers());
        Debug.Log(col2D.IsTouchingLayers());
        rb2D.MovePosition(rb2D.position + velocity*Time.deltaTime);
        Debug.Log(rb2D.OverlapPoint(new Vector2(-2.31f, -2.1f)));
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log(1);
            rb2D.GetContacts(contactPoints);
            for (int i = 0; i < contactPoints.Count; i++)
            {
                Debug.Log(contactPoints[i].point);
            }
        }    
    }
}
