using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
	public float runSpeed = 7;
	public float rotSpeed = 250;

	public Animator animator;

	private float x, y;

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotSpeed, 0);

        transform.Translate(0,0, y * Time.deltaTime * runSpeed);

        animator.SetFloat("Vx", x);
        animator.SetFloat("Vy",y);
    }
}