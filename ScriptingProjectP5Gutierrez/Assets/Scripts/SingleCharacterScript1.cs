using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScript1 : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }


    public Stuff myStuff = new Stuff(10, 7, 25);
    public float speed;


    // Start is called before the first frame update

    void Start() 
    { 
    
    
    }

    // Update is called once per frame
    void Update()
    {
    
    
    }
}
