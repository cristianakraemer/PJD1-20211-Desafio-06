using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyBehaviour { None, Patrol, Seek }
public class EnemyController : Rigidbody2DBase, IPoolableObject
{
    public int Hp { get; protected set; }

    // NavMesh e seguir player
    private NavMeshAgent agent;
    private GameObject player;

    public EnemyBehaviour behaviour = EnemyBehaviour.Patrol;
    [Header("Patrulha")]
    public Transform current;


    private void Start()
    {
        Hp = Random.Range(100, 201);

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
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
    }

    public bool ApplyDamage(int damage)
    {
        Hp -= damage;
        if(Hp<=0)  
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
    {
        agent.SetDestination(player.transform.position);
    }

}

