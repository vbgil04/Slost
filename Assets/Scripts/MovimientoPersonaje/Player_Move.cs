using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{

    //VARIABLES DE MOVIMIENTO Y SALTO
    public CharacterController controller;
    private float speed;
    private float jH;
    public float gravity = -9.81f;

    private Vector3 velocity;
    private bool isGrounded;
    private bool isSlimed;

    public Transform groundCheck;
    public Transform slimeCheck;
    public float groundDistance = 0.4f;
    public float slimeDistance = 0.4f;
    public LayerMask groundMask;
    public LayerMask slimeMask;

    //VARIABLES DE CAIDA
    public int maxHP, HP;
    public int dañoPorMetro;
    public int alturaSegura;

    [Range(0.001f,1)]
    public float umbralCaida;

    [Range(0.0001f, 0.1f)]
    public float tiempoActualizacion;

    public float[] listaVelocidadesVerticales;
    public float velocidadCaidaPromedio;

    bool caidaTermino, caidaLibre, calcularVelocidadCaidaPromedio, personajeCayendo;
    float tiempoParaRevisarCaida, alturaActualA, alturaActualB, alturaActualC, switcher, tiempoCayendo, tiempoDeCaida, velocidadCaidaAcumulada;
    int dañoRecibido, dañoRecibidoTemporal, metrosCaidos, velocidadYActual;

    Vector3 velocidadVertical;
    Vector2 alturaInicialYFinal;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        HP = maxHP;
        if(alturaSegura <= 1) { alturaSegura = 1; }
        alturaActualA = transform.position.y;
        alturaActualB= transform.position.y;
        alturaActualC= transform.position.y;
    }

    public void MetodoCaida() {
        tiempoParaRevisarCaida += Time.deltaTime;
        if(tiempoParaRevisarCaida >= tiempoActualizacion)
        {
            if (switcher == 0)
            {
                if (!personajeCayendo)
                {
                    alturaActualA = transform.position.y;
                }
            }
            if(switcher == 1)
            {
                if(transform.position.y >= alturaActualA)
                {
                    alturaActualA = transform.position.y;
                }
                else
                {
                    alturaActualB = transform.position.y;
                    personajeCayendo = true;
                    velocidadCaidaPromedio = 0;

                }
            }
            if(switcher == 2)
            {
                if (personajeCayendo)
                {
                    alturaActualC = transform.position.y;
                    if(alturaActualC < alturaActualB)
                    {
                        personajeCayendo = true;
                        listaVelocidadesVerticales[velocidadYActual] = Mathf.Abs(alturaActualC-alturaActualB);
                        velocidadYActual++;
                    }
                    else
                    {
                        personajeCayendo = false;
                        caidaTermino = true;
                    }
                    alturaActualB = alturaActualC;
                }
            }
            if (personajeCayendo)
            {
                alturaInicialYFinal.x = alturaActualA;
            }
            switcher++;
            if(switcher >= 3)
            {
                switcher = 0;
            }
            tiempoParaRevisarCaida = 0;
        }
        if (personajeCayendo)
        {
            tiempoCayendo += Time.deltaTime;
        }
        if (caidaTermino)
        {
            personajeCayendo = false;
            tiempoDeCaida = tiempoCayendo;
            alturaInicialYFinal.y = alturaActualC;
            float metersFallenTemp = Mathf.Abs((alturaInicialYFinal.x) - (alturaInicialYFinal.y));
            metrosCaidos = Mathf.RoundToInt(metersFallenTemp);
            calcularVelocidadCaidaPromedio = true;
            if (calcularVelocidadCaidaPromedio)
            {
                for(int a=0; a < velocidadYActual; a++)
                {
                    velocidadCaidaAcumulada += listaVelocidadesVerticales[a];
                }
                velocidadCaidaPromedio = (velocidadCaidaAcumulada / (float)velocidadYActual);
                for (int a=0; a < listaVelocidadesVerticales.Length; a++)
                {
                    listaVelocidadesVerticales[a] = 0;
                }
                velocidadCaidaAcumulada = 0;
                velocidadYActual = 0;
                calcularVelocidadCaidaPromedio = false;
            }
            if (velocidadCaidaPromedio >= umbralCaida)
            {
                float safeHeightTranformation = (metrosCaidos - alturaSegura);
                if(safeHeightTranformation <= 0)
                {
                    safeHeightTranformation = 0;
                }
                //calculamos el daño y bajamos HP
                if(!isSlimed)
                {
                    dañoRecibido = (dañoPorMetro * (int)safeHeightTranformation);
                    dañoRecibidoTemporal += dañoRecibido;
                    HP -= (dañoPorMetro * (int)safeHeightTranformation);
                    if(HP <= 0)
                    {
                        HP = 0;
                    }
                }
            }
            tiempoCayendo = 0;
            caidaTermino = false;
            velocidadVertical.y = 0f;
        }
    }
    void Update()
    {
        // Comprueba si el personaje está en el suelo y/o en slime
        speed = GlobalVariables.playerSpeed;
        jH = GlobalVariables.jumpHeight;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        isSlimed = Physics.CheckSphere(slimeCheck.position, slimeDistance, slimeMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Asegura que el personaje se mantenga pegado al suelo
        }

        // Movimiento del personaje
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;
        controller.Move(move * speed * Time.deltaTime);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || GlobalVariables.slime_collision))
        {
            velocity.y = Mathf.Sqrt(jH * -2f * gravity);
        }

        // Aplicar gravedad
        velocity.y += 1.2f * gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //caida
        MetodoCaida();
    }
}