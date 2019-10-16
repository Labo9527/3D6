using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(this.transform.position.x > 10 || this.transform.position.x < -10){
                return;
            }
            if(this.transform.position.y > 10 || this.transform.position.y < -10){
                return;
            }
            if(this.transform.position.z < -10){
                return;
            }

        if(Sing.Instance.mode == 1){
            Debug.Log("9981");
            this.gameObject.GetComponent<Rigidbody>().AddForce(100f*(-this.transform.position+other.transform.position));
        }

        // if (true)
        // {
        //     Debug.Log("mode"+Sing.Instance.mode);
        // }
        // this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
        // if(this.transform.parent){
        //     Debug.Log("here");
        //     this.transform.parent.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000f);
        // }
    // 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
