using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidBackScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collision){
if(collision.gameObject.name.Equals("void")){
        transform.position = new Vector3(391 ,1, 447);

//do stuff
}
}
}
