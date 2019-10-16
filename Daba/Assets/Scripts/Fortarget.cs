using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        // this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        // gameObject.SetActive(false);
        if(other.gameObject.name != "target1" && other.gameObject.name != "target2" && other.gameObject.name != "target3" && other.gameObject.name != "target4" && other.gameObject.name != "target5"
        && Model.shooted==false){
            Model.shooted=true;
            if(this.gameObject.name == "target1"){
                Model.score+=5;
            }
            else if(this.gameObject.name == "target2"){
                Model.score+=4;
            }
            else if(this.gameObject.name == "target3"){
                Model.score+=3;
            }
            else if(this.gameObject.name == "target4"){
                Model.score+=2;
            }
            else if(this.gameObject.name == "target5"){
                Model.score+=1;
            }

        }
        // if(other.gameObject.tag == "target")
        // {
        //     gameObject.transform.parent.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //     gameObject.SetActive(false);
        //     int points = other.gameObject.name[other.gameObject.name.Length - 1] - '0';
        //     scene.showTips(points);
        //     scene.addScore(points);
        // }
    }

}
