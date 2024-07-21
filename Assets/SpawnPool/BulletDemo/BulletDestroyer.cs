using System;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    private BulletPooler<GameObject> pooler;

    public void SetPooler(BulletPooler<GameObject> pooler)
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