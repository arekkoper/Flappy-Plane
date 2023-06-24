using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject[] terrains;

    List<GameObject> createdTerrains = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < 2; i++)
        {
            var block = Instantiate(terrains[0], new Vector3(i * 8, 0, 0), Quaternion.identity);
            createdTerrains.Add(block);
        }
        StartCoroutine(CreateNewTerrain());
    }

    IEnumerator CreateNewTerrain()
    {
        for(int i = 2; true; i++)
        {
            yield return new WaitForSeconds(2f);
            var index = Random.Range(0, terrains.Length);
            var block = Instantiate(terrains[index], new Vector3(i * 8, 0, 0), Quaternion.identity);
            createdTerrains.Add(block);
        }
    }


}
