using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BasePooler<T> : MonoBehaviour where T : Object
{
    public T pooledObject;
    public List<T> passiveList;
    public List<T> activelist;
    public int baseAmount;

    public virtual void Start()
    {
        for (var counter = 0; counter != baseAmount; counter++)
        {
            passiveList.Add(Instantiate(pooledObject,transform));
        }
    }

    public T GetItem()
    {
        if (passiveList.Count == 0)
        {
            passiveList.Add(Instantiate(pooledObject,transform));
        }

        var item = passiveList[0];
        passiveList.Remove(item);
        activelist.Add(item);
        return item;
    }

    public void ReleaseItem(T item)
    {
        passiveList.Add(item);
        activelist.Remove(item);
    }
}