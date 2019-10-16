using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUserAction
{
    void GameOver();
}

public class View : MonoBehaviour
{
    private Model action;
    private GUIStyle fontstyle = new GUIStyle();
    private GUIStyle fontstyle1 = new GUIStyle();

    // Start is called before the first frame update
    void Start()
    {
        action = Controller.getInstance().currentModel as Model;
        fontstyle.fontSize = 30;
        fontstyle.normal.textColor = Color.yellow;
        fontstyle1.fontSize = 30;
        fontstyle1.normal.textColor = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnGUI(){
        GUI.Label(new Rect(10,40,200,200),"Score: " + Model.score, fontstyle);
        if(Model.wind_direction == 0){
            GUI.Label(new Rect(10,100,200,200),"Wind: Left with strength " + Model.strength, fontstyle);
        }
        else{
            GUI.Label(new Rect(10,100,200,200),"Wind: Right with strength " + Model.strength, fontstyle);
        }
    }

}