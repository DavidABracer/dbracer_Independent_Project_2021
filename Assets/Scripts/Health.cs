using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float StartingHealth = 10f;

    public float HealthPoints
    {
     get { return _HealthPoints; }
     set
        {
            _HealthPoints = Mathf.Clamp(value, 0f, 10f);

            if(_HealthPoints <= 0f)
            {

            }
        }
    }

    [SerializeField]
    private float _HealthPoints = 10f;

    // Start is called before the first frame update
    void Start()
    {
        HealthPoints = StartingHealth;
    }
        
    }

