using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetowards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    
    {
      
         transform.position = Vector3.MoveTowards(transform.position,new Vector3(0,0,0), 3*Time.fixedDeltaTime);
    }   
}
