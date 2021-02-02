using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float speed = 1f;

    private CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;
        
        
        
        if (Input.GetKey(KeyCode.Z))
            move += transform.forward;
        else if (Input.GetKey(KeyCode.S))
            move -= transform.forward;
        
        if (Input.GetKey(KeyCode.D))
            move += transform.right;
        else if (Input.GetKey(KeyCode.Q))
            move -= transform.right;

        cc.Move(move.normalized * speed * Time.deltaTime + Vector3.down);
    }
}
