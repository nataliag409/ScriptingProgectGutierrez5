using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCharacterScript : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc);
        {
           bulletes = bul;
           grenades = gre;
           rockets = roc;
        }
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
