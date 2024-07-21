using System.Collections;
using UnityEngine;

public class BulletSpawner : BulletPooler<GameObject>
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private float destroyDelay;

    [SerializeField] private Transform border1;
    [SerializeField] private Transform border2;

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(border1.position.x, border2.position.x);
        float z = Random.Range(border1.position.z, border2.position.z);
        return new Vector3(x, 0f, z);
    }

    public override void Start()
    {
        base.Start();
        StartCoroutine(ItemSpawner());
    }

    private IEnumerator ItemSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            var item = GetItem();
            if (item != null)
            {
                item.SetActive(true);
                item.transform.position = GetRandomPosition();
                // Assign the pooler reference
                var itemDestroyer = item.GetComponent<BulletDestroyer>();
                if (itemDestroyer != null)
                {
                    itemDestroyer.SetPooler(this);
                }
                StartCoroutine(ItemDestroyerCoroutine(item));
            }
        }
    }

    private IEnumerator ItemDestroyerCoroutine(GameObject item)
    {
        yield return new WaitForSeconds(destroyDelay);
        item.SetActive(false);
        ReleaseItem(item);
    }
}