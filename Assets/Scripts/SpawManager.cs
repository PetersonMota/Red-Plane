using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{
    public GameObject Object;
    public Transform SpawmPos;

    public float MaxSpawPosY;
    public float MinSpawPosY;

    public float SpawnRate;
    public float ObstacleLifeTime;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), SpawnRate, SpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GetRandomPos()
    {
        var _position = SpawmPos.position;
        var _randomPosY = Random.Range(MinSpawPosY, MaxSpawPosY);

        _position.y += _randomPosY;

        return _position;

    }

    private void SpawnObstacle()
    {
        var _obstacle = Instantiate(Object, GetRandomPos(), Quaternion.identity);
        Destroy(_obstacle, ObstacleLifeTime);    
    }
}
