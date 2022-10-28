using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface : MonoBehaviour
{
    // Start is called before the first frame update
    interface ISpeak
    {
        void Speak();
    }    
    public class Animal: ISpeak
    {
        public void Speak()
        {
            Debug.Log("animal is speaking...");
        }
    }
    private void Start()
    {
        Animal animal = new Animal();
        ISpeak ani = new Animal();
        ani.Speak();
        animal.Speak();
    }
}
