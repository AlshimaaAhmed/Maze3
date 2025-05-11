using UnityEngine;

public class SimpleDoorTrigger : MonoBehaviour
{
    public Transform door;
    private Vector3 targetPosition;
    private float doorSpeed = 9f;
    public AudioSource winSound;

    private bool doorOpened = false;

    private string doorName;

    void Start()
    {
        if (door != null)
        {
            doorName = door.gameObject.name;
            targetPosition = new Vector3(door.position.x, door.position.y - 25f, door.position.z);

            // ·Ê «·»«» „› ÊÕ „‰ ﬁ»·° ·«  ﬂ—— «·› Õ
            if (DatatoBeShared.EnteredDoors.Contains(doorName))
            {
                GetComponent<Collider>().enabled = false;
                this.enabled = false;
                door.position = targetPosition;
            }
        }
        else
        {
            Debug.LogWarning("Door reference is not assigned!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!doorOpened && other.CompareTag("Player"))
        {
            doorOpened = true;

            if (winSound != null)
                winSound.Play();

            PlayerManager.Instance.AddCoins(200);

            DatatoBeShared.EnteredDoors.Add(doorName);

            if (GetComponent<Collider>() != null)
                GetComponent<Collider>().enabled = false;

        }
    }

    void Update()
    {
        if (doorOpened)
        {
            door.position = Vector3.MoveTowards(door.position, targetPosition, doorSpeed * Time.deltaTime);

            if (Vector3.Distance(door.position, targetPosition) < 0.01f)
            {
                door.position = targetPosition;
                doorOpened = false;
                this.enabled = false; 
            }
        }
    }
}
