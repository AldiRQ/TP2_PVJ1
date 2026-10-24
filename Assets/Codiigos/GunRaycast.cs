using UnityEngine;

public class GunRaycast : MonoBehaviour
{
    public float rayDistance = 50f;

    public LayerMask layerMask;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        Vector3 origin = transform.position;

        Vector3 direction = transform.forward;

        if (Physics.Raycast(origin, direction, out hit, rayDistance, layerMask))
        {
            Debug.Log("Hemos colisionado con: " + hit.collider.gameObject.name);

            if(hit.collider.CompareTag("Enemy1"))
            {   
                Destroy(hit.collider.gameObject);
            }

            Debug.DrawLine(origin, hit.point, Color.red);
        }
        else
        {
            Debug.DrawLine(origin, direction * rayDistance, Color.green);
        }



    }
}
