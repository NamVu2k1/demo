using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // Start is called before the first frame update
    private Collider2D col2D;
    public Collider2D Col2D;

    public ContactFilter2D cf;
    List<RaycastHit2D> ray2d = new List<RaycastHit2D>();
    void Start()
    {
        col2D = gameObject.GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //col2D.Raycast(new Vector2(0, -1), cf, ray2d, 2);
        //foreach (var x in ray2d)
        //{
        //    Debug.Log(x.collider.name);
        //}


        // Debug.Log(col2D.IsTouching(Col2D));


        col2D.Cast(new Vector2(0, -1), cf, ray2d, 2f);
        foreach (var x in ray2d)
        {
            Debug.Log(x.collider.name);
        }
         //Debug.Log(col2D.ClosestPoint(Vector2.zero));
        // Debug.Log(col2D.Distance(Col2D).distance);
    }
}