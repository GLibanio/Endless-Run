using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_Movement : MonoBehaviour
{
    Animator anim;
    CharacterController Movement;
    public TextMeshProUGUI Metros_Unidade;
    public TextMeshProUGUI Metros_Dezena;
    public TextMeshProUGUI Metros_Cem;
    public TextMeshProUGUI Metros_MIL;

    public bool perdeu;
    public float speed;
    public float speedX;
    public float Metros_Corrido_Uni;
    public int Metros_Corrido_Dez;
    public int Metros_Corrido_Centena;
    public int Metros_Corrido_MIl;

    bool InputJump;
    public float InputX;
    bool Onground;
    float gravity = 9.8f;
    public float JumpHeight = 1f;
    float velY;
    public float moveSpeed = 3;
    public float LeftRightSpeed = 4;
    void Start()
    {
        Movement = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Metros_Unidade.text = Metros_Corrido_Uni.ToString("F2");
        Metros_Dezena.text = Metros_Corrido_Dez.ToString();
        Metros_Cem.text = Metros_Corrido_Centena.ToString();
        Metros_MIL.text = Metros_Corrido_MIl.ToString();

        InputJump = Input.GetButtonDown("Jump");
        InputX = Input.GetAxisRaw("Horizontal");

        if (!perdeu)
        {
            Move();
            Jump();
        }
    }
    void Move()
    {
        var Final_Move = transform.forward * speed;
        Final_Move.y = velY;

        if (InputX == -1 && transform.position.x >= -1.1f)
        {
            Final_Move.x = InputX * speedX;
        }
        if (InputX == 1 && transform.position.x <= 1.1f)
        {
            Final_Move.x = InputX * speedX;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Movement.height = 1.08f;
            Movement.center = new Vector3(0, 0.5f,0);
            anim.SetBool("Roll", true);
            Invoke("StopRoll", 1.1f);
        }

        Metros_Corrido_Uni += 1 * Time.deltaTime;

        if(Metros_Corrido_Uni > 9)
        {
            Metros_Corrido_Dez += 1;
            Metros_Corrido_Uni = 0;
            if (Metros_Corrido_Dez > 9)
            {
                Metros_Corrido_Centena += 1;
                Metros_Corrido_Uni = 0;
                Metros_Corrido_Dez = 0;
                if(Metros_Corrido_Centena > 9)
                {
                    Metros_Corrido_MIl += 1;
                    Metros_Corrido_Centena = 0;
                    Metros_Corrido_Uni = 0;
                    Metros_Corrido_Dez = 0;
                }
            }
        }
        

        Movement.Move(Final_Move * Time.deltaTime);
    }
    void Jump()
    {
        velY -= gravity * Time.deltaTime;

        if(velY <= -2)
        {
            velY = -2;
        }
        Onground = Movement.isGrounded;

        if(Onground && InputJump)
        {
            velY = Mathf.Sqrt(JumpHeight * 3 * gravity);
        }

        if (Onground)
        {
            anim.SetBool("Jump", false);
        }
        else
        {
            anim.SetBool("Jump", true);
        }
    }

    void StopRoll()
    {
        Movement.height = 1.63f;
        Movement.center = new Vector3(0, 0.8f, 0);
        anim.SetBool("Roll", false);
    }
}
