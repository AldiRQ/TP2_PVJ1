using UnityEngine;

public class LevelGoal : MonoBehaviour
{
    private bool levelCompleted;

    private void OnTriggerEnter(Collider other)
    {
        if (levelCompleted)
        {
            return;
        }

        if (other.CompareTag("Player"))
        {
            return;
        }

        levelCompleted = true;

        Debug.Log("¡NIVEL COMPLETADO!");
    }
}
