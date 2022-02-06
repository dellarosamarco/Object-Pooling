using UnityEngine;

public class Example : MonoBehaviour
{
    public GameObject sphere;
    public Pool pool;

    private void Start()
    {
        pool = new Pool(mainObject : sphere, poolSize : 20, initialState : false);
    }
}
