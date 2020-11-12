using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;

    float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward*Time.deltaTime*speed);
            playerAnim.SetBool("isForward", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerAnim.SetBool("isForward", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            playerAnim.SetBool("isAttack", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerAnim.SetBool("isAttack", false);
        }
        if ()
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerAnim.SetBool("isDeath", false);
        }
    }
}
