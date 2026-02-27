using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("Player");
        PlayerController player = go.GetComponent<PlayerController>();
        if (player.IsGameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);  
        }
              
    }
}
