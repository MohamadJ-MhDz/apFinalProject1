using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15f;
    public float timer_deactivation = 0.5f;
    void Start()
    {
        Invoke("DeactivateGameObject", timer_deactivation);
    }

    void Update()
    {
        bulletMove();
    }

    void bulletMove()
    {
        Vector3 temp_pos = transform.position;
        temp_pos.y += speed * Time.deltaTime;
        transform.position =  temp_pos;  
    }

    void DeactivateGameObject ()
    {
        gameObject.SetActive(false);    
    }
}
