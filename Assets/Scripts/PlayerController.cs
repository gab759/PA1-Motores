using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocityModifier = 5f;


    // Start is called before the first frame update
     void Start()
    {
        if (myRBD == null)
        {
            myRBD = GetComponent<Rigidbody>();
        }
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
            Vector3 movementPlayer = context.ReadValue<Vector3>();
            myRBD.velocity = movementPlayer * velocityModifier; 
        
    }

    // Update is called once per frame          
    private void Update()
    {
        /* if (Input.GetKeyDown(KeyCode.J))    
        {
            isActivePlayer = false; 
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            isActivePlayer = true; 
        }*/
    }
}
