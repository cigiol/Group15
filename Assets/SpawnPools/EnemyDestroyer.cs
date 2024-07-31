using System;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    private BasePooler<GameObject> pooler;

    public void SetPooler(BasePooler<GameObject> pooler)
    {
        this.pooler = pooler;
    }

    private void Update()
    {
        OnType();
    }

    public void OnType()
    {
        if (pooler != null && Input.GetKey(KeyCode.D))
        {
            gameObject.SetActive(false);
            pooler.ReleaseItem(gameObject);
        }
    }
}