using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class enemys
{
    public string name;
    public int size;
    public GameObject prefab;
}
public class objectpooling : MonoBehaviour
{
    // Start is called before the first frame update
    
   

    public List<enemy> enemies;

    public Dictionary<string, Queue<object>> Dic;

    // Update is called once per frame
    private void Awake()
    {
        
    }
}
