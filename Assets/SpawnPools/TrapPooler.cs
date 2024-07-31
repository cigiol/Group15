using System.Collections;
using UnityEngine;

public class TrapPooler : BasePooler<GameObject>
{
    public float spawnDelay;
    public float destroyDelay;
    private float currentDestroy;

    public Transform Gameborder1;
    public Transform Gameborder2;

    private Vector3 GetRandomPosition()
    {
        float x = UnityEngine.Random.Range(Gameborder1.position.x, Gameborder2.position.x);
        float z = UnityEngine.Random.Range(Gameborder1.position.z, Gameborder2.position.z);
        return new Vector3(x, 0f, z);
    }

    public override void Start()
    {
        base.Start();
        StartCoroutine(ItemSpawner());

        currentDestroy = destroyDelay;

    }

    private IEnumerator ItemSpawner()
    {
        while (Time.time <= 60)
        {
            yield return new WaitForSeconds(spawnDelay);
            var item = GetItem();
            item.SetActive(true);
            item.transform.position = GetRandomPosition();
            // Assign the pooler reference
            var itemDestroyer = item.GetComponent<EnemyDestroyer>();
            if (itemDestroyer != null)
            {
                itemDestroyer.SetPooler(this);
            }
            StartCoroutine(ItemDestroyerCoroutine(item));
        }
    }

    private IEnumerator ItemDestroyerCoroutine(GameObject item)
    {
        yield return new WaitForSeconds(destroyDelay);
        item.SetActive(false);
        ReleaseItem(item);
    }

    void ActiveListLimiter()
    {
        if (activelist.Count > 20)
        {
            currentDestroy = 100f;
        }

        else
        {
            currentDestroy = spawnDelay;
        }
    } 
}