using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerDestination;
    private NavMeshAgent agent;

    public float movementSpeed = 3f; // Adjust this value as needed

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetNewDestination(playerDestination.position);
    }

    void Update()
    {
        // You can add any additional logic here if needed
    }

    public void SetNewDestination(Vector3 newPosition)
    {
        agent.speed = movementSpeed; // Set the agent's speed
        agent.SetDestination(newPosition);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DisableNavMesh"))
        {
            // Disable navigation when entering the trigger collider
            agent.enabled = false;
        }
    }
}

