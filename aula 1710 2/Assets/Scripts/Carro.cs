using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Carro : MonoBehaviour
{
    public float speed = 2f; 
    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0, 0) * speed * Time.deltaTime;
        transform.position += movement;
    }

}
