using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    public enum EnemyState
    {
        patrol,
        chase,
        search,
        attack,
        retreat
    }
    public EnemyState state;
    // Start is called before the first frame update
    void Start()
    {
        state = EnemyState.patrol;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case EnemyState.patrol:
                Patrolling();
                break;
            case EnemyState.chase:
                Chasing();
                break;
            case EnemyState.search:
                Searching();
                break;
            case EnemyState.attack:
                Attacking();
                break;
            case EnemyState.retreat:
                Retreating();
                break;
        }
    }

    void Patrolling()
    {

    }

    void Chasing()
    {

    }

    void Searching()
    {

    }

    void Attacking()
    {

    }

    void Retreating()
    {

    }
}
