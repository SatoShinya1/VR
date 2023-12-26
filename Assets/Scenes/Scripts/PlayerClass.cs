using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    // Start is called before the first frame update

    public int jemCount = 0;
    public int GetPoint = 0;

    void Start()
    {
        
    }

    public void jemFluctuation(){
        jemCount++;
        Debug.Log("jem:"+jemCount);

        if(jemCount >= 10){
            Debug.Log("勝利(jem)");
        }
    }

    public void pointFluctuation(){
        GetPoint++;
        Debug.Log("point:"+GetPoint);

        if(GetPoint >= 10){
            Debug.Log("勝利(point)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        

        
    }
}
