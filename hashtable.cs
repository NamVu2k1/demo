using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hashtable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Hashtable hash = new Hashtable();
        
        hash.Add("N", "Nam");
        hash.Add(14, "Van");
        if(hash["V"] == null)
        {
            hash.Add("V", "Vu");
        }
        Debug.Log(hash[14]);
       
        foreach(DictionaryEntry x in hash)
        {
            Debug.Log(x.Key + " " + x.Value);
        }    

    }

    // Update is called once per frame
    
}
