using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    [Header("Inscribed")]
    public GameObject applePrefab;

    // Speed at which apple tree moves
    public float speed = 1f;

    // Distance for when tree turns around
    public float leftAndRightEdge = 10f;


    // Chance to change direction
    public float changeDirChance = 0.1f;

    // Seconds between apple instantiations
    public float appleDropDelay = 1f;








    // Start is called before the first frame update
    void Start()
    {
        // Begin apple drop
        Invoke("DropApple", 2f);
    }

    void DropApple() {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        // Movement 
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Change direction
        if(pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed); // Move right
        } 
        else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed); // Move Left
        }
        // else if (Random.value < changeDirChance) {
        //     speed *= -1;
        // }
    }

    void FixedUpdate() {
        if (Random.value < changeDirChance) {
            speed *= -1;
        }
    }
}
