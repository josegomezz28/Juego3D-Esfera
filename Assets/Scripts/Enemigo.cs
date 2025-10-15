using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemigo : MonoBehaviour
{
    public Transform playerTransform;
    private UnityEngine.AI.NavMeshAgent navMeshAgent;
    public static int vecesMuerto;
    
    void Start()
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        playerTransform = FindAnyObjectByType<Esfera>().transform;
    }

  
    void Update()
    {
        navMeshAgent.destination = playerTransform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Esfera"))
        {
            SceneManager.LoadScene(1);
        }
    }

}
