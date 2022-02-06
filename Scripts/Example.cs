using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject sphere;
    public Transform objectsContainer;
    public Pool pool;

    private void Start()
    {
        pool = new Pool(
            mainObject : sphere, 
            poolSize : 500, 
            initialState : false, 
            parent : objectsContainer,
            startPosition : randomPos(),
            pooledObjectName : "Sphere"
        );
    }

    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;

        if(timer > 0)
        {
            //Spawn next object to a random position
            GameObject sphere = pool.spawnAt(randomPos());
            sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;

            //Spawn object to a random position by giving its index
            //pool.spawnAt(randomPos(), index : 5);

            //Spawn a certain object to a random position
            //pool.spawnAt(randomPos(), pool.pool[5]);

            //Increase pool size
            //pool.increasePoolSize(5, initialState: true, parent : objectsContainer);

            
            timer = 0;
        }
    }

    private Vector3 randomPos()
    {
        Vector3 temp;
        temp.x = Random.Range(-5f, 5f);
        temp.y = Random.Range(-5f, 5f);
        temp.z = Random.Range(-5f, 5f);
        return temp;
    }
}
