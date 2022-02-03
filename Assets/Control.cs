using UnityEngine;

public class Control : MonoBehaviour
{
    bool MouseDown = false;
    public int index, i;
    private int index2, index3;
    Vector3 startPosicion;
    private GameManager gameManager;
    void Start()
    {
        startPosicion = GetComponent<Transform>().position;
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    { MouseDown = true; }

    private void OnMouseUp()
    { MouseDown = false; }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == $"{index}")
        { this.gameObject.SetActive(false); gameManager.a ++; }
        else if (other.gameObject.tag == $"{index2}" || other.gameObject.tag == $"{index3}")
        { MouseDown = false; gameManager.i --; }
    }
    void Update()
    {
        if (index == 1)
        { index2 = 2; index3 = 3; }

        if (index == 2)
        { index2 = 1; index3 = 3; }

        if (index == 3)
        { index2 = 2; index3 = 1; }

        Vector2 Cursor = Input.mousePosition;
        Cursor = Camera.main.ScreenToWorldPoint(Cursor);

        if (MouseDown)
        { this.transform.position = Cursor; }
        else this.transform.position = startPosicion;
    }
}
