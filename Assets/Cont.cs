using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cont : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnButton(InputValue input){
        if(input.isPressed){
            panel.SetActive(true);
        }
        else{
            panel.SetActive(false);
        }

    }
    void OnDrop()
    {
        gameObject.AddComponent<Rigidbody>();
    }                                                 
}
