using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaHinh : MonoBehaviour
{
    class Animal
    {

        public string ten(string name)
        {
            return name;
        }
        public string ten(int mssv)
        {
            return mssv.ToString();
        }
        public virtual void Speak()
        {
            Debug.Log(" Animal is speaking. . .");
        }
     
    }


    class Cat : Animal
    {
        public override void Speak()
        {
            Debug.Log(" Cat is speaking. . .");
        }
       

    }


    class Dog : Animal
    {
        public override void Speak()
        {
            Debug.Log(" Dog is speaking. . .");
        }
    }

    private void Start()
    {
        Animal cat = new Cat();
        Animal dog = new Dog();

        cat.Speak();
        dog.Speak();
       
    }
}
