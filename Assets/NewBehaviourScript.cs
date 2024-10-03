using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody xdd;
    public Character yes;

    public Vector3 vecy = new Vector3(5, 5, 5);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        System.Console.WriteLine(yes.get_atk());
        if (Input.GetKeyDown(KeyCode.W))
        {
            xdd.velocity = Vector3.fwd * 10;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            xdd.velocity = Vector3.back * 10;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            xdd.velocity = Vector3.left * 10;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            xdd.velocity = Vector3.right * 10;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            xdd.velocity = Vector3.up * 10;
        }
    }
}
