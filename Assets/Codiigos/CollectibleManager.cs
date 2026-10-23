using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private int collectibleCount;

    [SerializeField] private CollectibleUI collectibleUI;

    private void Awake()
    {
        Instance = this;
    }

    public void AddCollectible()
    {
        collectibleCount++;
        Debug.Log("Collectible Count: " + collectibleCount);

        collectibleUI.UpdateCounter(collectibleCount);
    }

    public int GetCollectibleCount()
    {
        return collectibleCount;
    }
}
