using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [SerializeField] private GameObject _applePrefab;
    public float spawnRadius = 8;
    public float rate;
    float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = rate;
    }

    // Update is called once per frame
    void Update()
    {

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {

                Vector2 randomPoint = Random.insideUnitCircle.normalized;
            Vector3 spawnPoint = new Vector3(spawnRadius * randomPoint.x, 3, spawnRadius * randomPoint.y);
                SpawnAppleAtPosition(transform.position + spawnPoint);

            spawnTimer = rate;
        }

        //if (Input.GetMouseButtonDown(0))
        //{
        //    //Vector3 mousePos = Input.mousePosition;
        //    //Ray ray = Camera.main.ScreenPointToRay(mousePos);

        //    //if(Physics.Raycast(ray, out RaycastHit hitInfo))
        //    //{
        //    //    SpawnAppleAtPosition(hitInfo.point);
        //    //}
        //    Vector2 randomPoint = Random.insideUnitCircle.normalized;
        //    SpawnAppleAtPosition(transform.position + new Vector3(spawnRadius*randomPoint.x, 3, spawnRadius * randomPoint.y));
        //}
    }

    private void SpawnAppleAtPosition(Vector3 spawnPosition)
    {
        GameObject apple = Instantiate(_applePrefab, spawnPosition, Quaternion.identity);
        apple.transform.Rotate(Random.rotation.eulerAngles);
    }

}
