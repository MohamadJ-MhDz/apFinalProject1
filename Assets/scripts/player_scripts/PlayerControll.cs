using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Spaceship controll script
public class PlayerControll : MonoBehaviour
{
    public float speed = 6.2f;
    public float min_x = -3.88f, max_x = 3.88f;

    [SerializeField]
    private GameObject bullet;

    [SerializeField] 
    private Transform spawn_point;

    private Vector3 follow_mouse = Input.mousePosition;

    public float attack_timer = 0.005f;
    private float current_attack_timer;
    private bool attack_permission;

    void Start()
    {
        current_attack_timer = attack_timer;
    }

    void Update()
    {
        playerMove();
        fire();
        
    }

    void playerMove()
    {


        if (Input.GetAxisRaw("Horizontal") > 0f) //Input.GetAxisRaw("Horizontal") > 0f
        {
            Vector3 temp_pos = transform.position; 
            temp_pos.x += Time.deltaTime * speed;

            if (temp_pos.x > max_x)     //restricting right edge
                temp_pos.x = max_x;
            
            transform.position = temp_pos;
        }   

        else if (Input.GetAxisRaw("Horizontal") < 0f) //Input.GetAxisRaw("Horizontal") < 0f
        {
            Vector3 temp_pos = transform.position;
            temp_pos.x -= Time.deltaTime * speed;

            if (temp_pos.x < min_x)      //restricting left edge
                temp_pos.x = min_x; 

            transform.position = temp_pos;
        }
    }

    void fire()
    {
        attack_timer += Time.deltaTime;
        if (attack_timer > current_attack_timer)
        {
            attack_permission = true;
        }
        

        if (Input.GetMouseButtonDown(0))
        {
            if (attack_permission)
            {
                attack_permission = false;
                attack_timer = 0f;
                Instantiate(bullet, spawn_point.position, Quaternion.identity);

            }
        }

    } 

}
