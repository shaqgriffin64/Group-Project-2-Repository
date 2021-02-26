using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    //variable that determines how far away an enemy can see
    public float lookRadius = 10f;

    //funny dialogue
    public Text warningText;

    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        warningText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <=  lookRadius)
        {
            agent.SetDestination(target.position);

            warningText.text = "You look a little rough around the edges";

            if (distance <= agent.stoppingDistance)
            {
                //Attack the target 
                //Face the Target
                FaceTarget();
            }
        }
        if (distance >= lookRadius)
        {
            warningText.text = "";
        }
    }

    //function for facing the player when the AI is withing stopping distance of the player
    void FaceTarget ()
    {
        Vector3 direction = (target.position - transform.position).normalized;

        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));

        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    //draws a red sphere acting as the detection radius for the AI
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
