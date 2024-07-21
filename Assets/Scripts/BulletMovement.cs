using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float bulletSpeed = 20f;

    private BulletPooler<GameObject> pooler;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != null)
        {
            gameObject.SetActive(false);
            pooler.ReleaseItem(gameObject);
            Debug.Log("Pooled");
        }
    }

    public void OnEnable()
    {
        var bullet = pooler.GetItem();
        if (rb != null)
        {
            rb.velocity = transform.forward * bulletSpeed;
        }
        
    }
}