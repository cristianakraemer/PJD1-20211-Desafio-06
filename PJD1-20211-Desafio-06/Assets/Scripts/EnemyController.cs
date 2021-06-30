using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

<<<<<<< Updated upstream
public enum EnemyBehaviour { None, Patrol, Seek }
=======
public enum EnemyBehaviour { None, Patrol, Seek}
>>>>>>> Stashed changes
public class EnemyController : Rigidbody2DBase, IPoolableObject
{
    public int Hp { get; protected set; }

<<<<<<< Updated upstream
    // NavMesh e seguir player
    private NavMeshAgent agent;
    private GameObject player;

    public EnemyBehaviour behaviour = EnemyBehaviour.Patrol;
    [Header("Patrulha")]
    public Transform current;

=======
    // NavMesh persegue o Player
    private GameObject player;
    private NavMeshAgent agent;

    public EnemyBehaviour behaviour = EnemyBehaviour.Patrol;
    [Header("Patrulha")]
    public Transform current;


    /*/ Patrulha
    public Transform currentTarget; // Pivô, ponto zero.
    public Transform point1; // Pivô 1.
    public Transform point2; // Pivô 2.

    // Seguir o jogador e campo de visão...
    float SpeedEnemy = 2f;
    float StopDistance = 3f;
    private Transform TargetVision; // Campo de visão.*/
>>>>>>> Stashed changes

    private void Start()
    {
        Hp = Random.Range(100, 201);

<<<<<<< Updated upstream
=======
        // Procura o GameObject com a Tag Player, acessando a sua posição.
       // TargetVision = GameObject.FindGameObjectWithTag("Player").transform;
      //  currentTarget = point1;

>>>>>>> Stashed changes
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
<<<<<<< Updated upstream
        Seek();

        switch(behaviour)
        {
            case EnemyBehaviour.None:
                break;
            case EnemyBehaviour.Patrol:
                break;
            case EnemyBehaviour.Seek:
                break;
        }
=======
        //Seek();
        
    }

    void EnemyStates()
    {
        switch (behaviour)
        {
            case EnemyBehaviour.None:
                break;

            case EnemyBehaviour.Patrol:
                break;

            case EnemyBehaviour.Seek:
                break;
        }
    }

    void Patrulha()
    {
        if (current == null)
        {
            behaviour = EnemyBehaviour.None;
            return;
        }
         
        
>>>>>>> Stashed changes
    }

    public bool ApplyDamage(int damage)
    {
        Hp -= damage;
        if (Hp <= 0)
            Destroy(gameObject);
        return Hp <= 0;
    }

    public void Recycle()
    {
        gameObject.SetActive(false);
    }

    public void TurnOn()
    {
        gameObject.SetActive(true);
        Start();
    }

    protected virtual void Seek()
<<<<<<< Updated upstream
    {
        agent.SetDestination(player.transform.position);
    }

}
=======
    {
        agent.SetDestination(player.transform.position);
    }

  /*  protected virtual void Patrol()
    {
        if (Vector2.Distance(transform.position, TargetVision.position) < StopDistance)
        {
            // Movimenta o gameObject até um ponto específico com uma velocidade.
            //transform.position = Vector2.MoveTowards(transform.position, TargetVision.position, SpeedEnemy * Time.deltaTime);
            agent.SetDestination(player.transform.position);
            Debug.LogFormat("Está vendo o Player");
        }
        else
        {
            // movimentação do inimigo até os pivôs.
            transform.position = Vector2.MoveTowards(transform.position, currentTarget.position, SpeedEnemy * Time.deltaTime);
            // movimentação do inimigo em patrulha, do pivô A ao pivô B, e vise versa.
            if (currentTarget == point1 && transform.position == point1.position)
                currentTarget = point2;
            if (currentTarget == point2 && transform.position == point2.position)
                currentTarget = point1;
        }
>>>>>>> Stashed changes

    }*/

    
}