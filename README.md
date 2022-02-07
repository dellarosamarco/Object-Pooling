# 3D Object Pooling 

## Create a simple pool
```c#
public Pool pool;
public GameObject sphere;

private void Start()
{
    pool = new Pool(mainObject : sphere, poolSize : 500);
}
```

## Customize a pool creation
```c#
public Pool pool;
public GameObject sphere;
public Transform objectsContainer;

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
```
