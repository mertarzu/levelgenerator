using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public List<PooledObject> PooledObjects = new List<PooledObject>();
    [SerializeField] PooledObject tilePrefab;
    [SerializeField] int amountToPool;
    [SerializeField] int additionAmountToPool;
    [SerializeField] string PoolName; 
    int tempAmountToPool;

    private void Awake()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            PooledObjects.Add(Create());
        }
    }
    
    public PooledObject Create()
    {
        PooledObject tempGameObject = GameObject.Instantiate(tilePrefab);
        tempGameObject.gameObject.SetActive(false);
        tempGameObject.gameObject.transform.SetParent(transform, true);
        return tempGameObject;
    }

    public PooledObject GetPooledObject()
    {
        PooledObject result = PooledObjects.Where(i => i.IsPooledObjectTaken == false).FirstOrDefault();
        if (result == null && tempAmountToPool < additionAmountToPool)
        {
            AddPooledObject();
            result = PooledObjects.Where(i => i.IsPooledObjectTaken == false).FirstOrDefault();
            ++tempAmountToPool;
        }
        return result;
    }

    public void AddPooledObject()
    {
        PooledObjects.Add(Create());
    }

    public  string GetPoolName()
    {
        return PoolName;
    }
}
