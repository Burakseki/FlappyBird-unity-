using UnityEngine;

public class Spawner : MonoBehaviour
{
 public GameObject pipePrefab;
private void Start() 
{
    InvokeRepeating("SpawnPipes",1f,1f);   
}



public void SpawnPipes()
{
   GameObject pipeClone = Instantiate(pipePrefab, new Vector3(10,Random.Range(-2,2),0) ,Quaternion.identity);

}

}
