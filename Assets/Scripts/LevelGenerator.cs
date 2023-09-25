using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] PoolManager objectpoolers;
    [SerializeField] List<float> percentageList = new List<float>();
    [SerializeField] int width;
    [SerializeField] int height;
    [SerializeField] List<string> tileName = new List<string>();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetLevel();
        }
    }

    void GetLevel() 
    {
        objectpoolers.Release();
        int initialX = -5;
        for (int x = initialX; x < width+initialX+1; x++)
        {
            for(int z = 0; z < height; z++)
            {
                Vector3 pos = new Vector3(x, 0, z);
          
                float percentNum = Random.Range(0,100);
                float compNum = 0;

                for (int i = 0; i < percentageList.Count; i++)
                {
                    compNum += percentageList[i];
                   
                    if (percentNum < compNum)
                    {
                        //PooledObject tileItem = objectpoolers.GetItemByName("Stone");
                        PooledObject tileItem = objectpoolers.GetItemByName(tileName[i]);
                        //PooledObject tileItem = objectpoolers.GetItemByIndex(i);
                        if (tileItem != null)
                        {
                            tileItem.Navigate(pos);
                        }
                        break;
                    }
                }           
            }
        }

    }
    
}
