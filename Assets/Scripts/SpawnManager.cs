using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;

    private Coroutine goodByeRoutine;

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new System.NotImplementedException();
    }

    IEnumerable SpawnRoutine()
    {
        yield return new WaitForSeconds(5);
        while (true)
        {
            RandomSpawn();
            yield return new WaitForSeconds(3);
        }
    }

    void RandomSpawn()
    {
        var index = Random.Range(0, spawnPoints.Length);
        var spawn = spawnPoints[index];
        Instantiate(enemyPrefab, spawn.position, Quaternion.identity);
    }

    IEnumerable Goodbye()
    {
        while(true)
        {
            Debug.Log("Bye" + Time.frameCount + " " + Time.deltaTime);
            //yield return new WaitForSeconds(1);
            yield return null;

            //StartCoroutine(Hello());

            yield return Hello();
        }
    }

    IEnumerator Hello()
    {
        Debug.Log("Hello" + Time.frameCount);
        Debug.Log("Hello" + Time.frameCount);
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
        Debug.Log("Hello" + Time.frameCount);
        yield return null;
        yield return null;
        yield return null;
        yield return null;
        Debug.Log("Hello" + Time.frameCount);
    }
}
