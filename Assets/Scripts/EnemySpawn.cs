using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _templete;
    [SerializeField] private float _time;
    [SerializeField] private float _countTemplete;
    
    private Transform[] _points;
    private float _runningTime, _counterTemplete;
    private int _index;
    private void Start()
    {
        _points = GetComponentsInChildren<Transform>();        
    }

    private void Update()
    {      
        if (_countTemplete >= _counterTemplete)
        {            
            _runningTime += Time.deltaTime;
            if (_time <= _runningTime)
            {
                _index = Random.Range(0, _points.Length - 1);
                GameObject gameObject = Instantiate(_templete, _points[_index].position, Quaternion.Euler(
                    Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
                gameObject.transform.localScale = new Vector3(Random.Range(1, 4), Random.Range(1, 4), Random.Range(1, 4));

                _runningTime = 0;
                _counterTemplete++;
            }
        }    
    }
}
