using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tit : MonoBehaviour
{
    public Transform tf;
    public bool shooted;
    // Start is called before the first frame update
    void Start()
    {
        // Vector3 v = new Vector3(5,1,1);
        this.gameObject.GetComponent<Rigidbody>().centerOfMass = tf.localPosition;
        shooted=false;
        // this.gameObject.GetComponent<Rigidbody>().AddForce(1f*v);
        // this.transform.LookAt(this.transform.position+v*100);
        // this.gameObject.GetComponent<Rigidbody>().AddTorque(v*1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z > 0.5){
            Model.shooted = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && Model.shooted==true){
            this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            Vector3 v = new Vector3(0, 0, -10);
            Model.shooted=false;
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            this.transform.position=v;


        float num = Random.Range(0f,5f);
        float num2 = Random.Range(0f, 2f);
        if(num<1){
            Model.strength = 1;
        }
        else if(num < 2){
            Model.strength = 2;
        }
        else if(num < 3){
            Model.strength = 3;
        }
        else if(num < 4){
            Model.strength = 4;
        }
        else if(num < 5){
            Model.strength = 5;
        }
        if(num2 < 1){
           Model.wind_direction = 0;
        }
        else{
            Model.wind_direction = 1;
        }

        }

        if(Model.shooted==false){
            Vector3 v = Camera.main.ScreenPointToRay(Input.mousePosition).direction;
            this.transform.LookAt(v);
        }
        if (Input.GetButtonDown("Fire1")) {
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            Vector3 v = Camera.main.ScreenPointToRay(Input.mousePosition).direction;
            this.gameObject.GetComponent<Rigidbody>().AddForce(10f*v,ForceMode.Impulse);
            if(Model.wind_direction == 0){
                Vector3 vv = new Vector3(-1, 0,0);
                this.gameObject.GetComponent<Rigidbody>().AddForce(25f*Model.strength*vv,ForceMode.Force);
            }
            else if(Model.wind_direction == 1){
                Vector3 vv = new Vector3(1, 0,0);
                this.gameObject.GetComponent<Rigidbody>().AddForce(25f*Model.strength*vv,ForceMode.Force);
            }
            this.transform.LookAt(v);
			Debug.Log (v);

		}
    }

    void OnTriggerEnter(Collider other)
    {

        this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        // gameObject.SetActive(false);
        // Debug.Log(1111);
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
