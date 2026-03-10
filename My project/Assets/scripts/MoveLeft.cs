using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerControler playerControlerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControlerScript = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControlerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
