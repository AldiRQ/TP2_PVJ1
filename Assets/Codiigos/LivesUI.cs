using UnityEngine;

public class LivesUI : MonoBehaviour
{
    [SerializeField] private GameObject[] hearts;

    public void UpdateLives(int currentLives)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            hearts[i].SetActive(i < currentLives);
        }
    }
}
