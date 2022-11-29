using UnityEngine;
using VisualDialougeTree;

public class chestScript : MonoBehaviour
{
    private bool playerInRange = false;
    private InteractionController interactionController;
    public DialougeContainer openedChestDialouge;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interactionController = collision.GetComponent<InteractionController>();
            playerInRange = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private void Update()
    {
        if (playerInRange && Input.GetButtonDown("Select"))
        {
            //Todo Add Lock Behavior
            interactionController.DisplayDialouge(openedChestDialouge);
        }
    }
}
