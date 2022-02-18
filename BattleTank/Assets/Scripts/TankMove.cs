using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float moveSpeed = 20.0f;
    public float rotSpeed = 50.0f;
    private Rigidbody rbody;
    private Transform tr;
    private float h, v;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        rbody.centerOfMass = new Vector3(0.0f, 0.5f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        tr.Rotate(Vector3.up * rotSpeed * h * Time.deltaTime);
        tr.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);
    }
}
