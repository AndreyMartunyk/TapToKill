using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TappingObjHelper : MonoBehaviour
{
    public int tapsToDestroy = 1;
    public int gainPoints = 1;
    public float lifeTime = 4f;

    private ScoreHelper points;
    // Start is called before the first frame update
    void Awake()
    {
        points = Camera.main.GetComponent<ScoreHelper>();
        if (!GetComponent<Collider2D>())
        {
            Debug.LogWarning("There are no Collider on object!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        TryDestroy();
    }

    private void TryDestroy()
    {
        if (tapsToDestroy <= 0)
        {
            points.AddScore(gainPoints);
            Destroy(gameObject);
        }
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        
        --tapsToDestroy;
    }
}
