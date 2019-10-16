using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ForModel{
    void LoadResources();
    void Pause();
    void Resume();
}

public class Model : MonoBehaviour, ForModel
{
    public static int score;
    public static bool shooted=false;
    public static int wind_direction = 0;
    public static int strength = 0;
    Controller controller;

    void Awake(){
        controller = Controller.getInstance();
        controller.setFPS(60);
        controller.currentModel = this;
        controller.running=true;
        LoadResources();
        score=0;
    }

    public void Start(){
        float num = Random.Range(0f,5f);
        float num2 = Random.Range(0f, 2f);
        if(num<1){
            strength = 1;
        }
        else if(num < 2){
            strength = 2;
        }
        else if(num < 3){
            strength = 3;
        }
        else if(num < 4){
            strength = 4;
        }
        else if(num < 5){
            strength = 5;
        }
        if(num2 < 1){
            wind_direction = 0;
        }
        else{
            wind_direction = 1;
        }
    }

    public void Restart(){

    }

    public void Resume(){

    }

    public void Pause(){
        controller.running=!controller.running;
    }

    public void LoadResources(){

    }


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {


    }
}