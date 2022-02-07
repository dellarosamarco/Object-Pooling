# 3D Object Pooling 
This library allows you to generate N objects while still maintaining high performance.

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

## Work this pools
```c#
public Pool pool;

public void test(){
    
}

```


