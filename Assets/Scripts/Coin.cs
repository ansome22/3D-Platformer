using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //How fast is the coin going to be rotating around?
    public float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the object we hit is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().AddScore(1);
            Destroy(gameObject);
        }
    }
}
