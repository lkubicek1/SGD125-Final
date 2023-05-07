using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;
    int currentNode;
    public enum EnemyState
    {
        patrol,
        chase
    };

    EnemyState enemyState = EnemyState.patrol;

    private readonly System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentNode = Random.Range(0, GameManager.gm.nodes.Length);
    }

    // Update is called once per frame
    void Update()
    {
        switch (enemyState)
        {
            case EnemyState.patrol: Patrol(); break;
            case EnemyState.chase: Chase(); break;
            default: break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "node")
        {
            currentNode = Enumerable.Range(0, GameManager.gm.nodes.Length)
                            .Where(index => index != currentNode)
                            .OrderBy(_ => random.Next())
                            .FirstOrDefault();
        }
        else if(other.tag == "Player")
        {
            enemyState = EnemyState.chase;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            enemyState = EnemyState.patrol;
        }
    }

    private void Patrol()
    {
        agent.destination = GameManager.gm.nodes[currentNode].transform.position;
    }

    private void Chase()
    {
        agent.destination = GameManager.gm.player.transform.position;
    }
}
