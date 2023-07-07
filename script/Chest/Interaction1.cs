using UnityEngine;
using UnityEngine.UI;

public class Interaction1 : MonoBehaviour
{
	public Text indicator;
	public Text  dodicator;
	public GameObject sas;
	public GameObject Player;
	void Update()
	{
		RaycastHit hit;
		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
			{

					if (hit.collider.tag == "krovat")
					{
						dodicator.enabled = true;
						if (Input.GetKeyDown(KeyCode.E))
						{
							sas.SetActive(true);
							Player.SetActive(false);
							dodicator.enabled = false;
						}
					}
				
					else
					{
						dodicator.enabled = false;
						//indicator.text = ".";
					}
			}
						else
						{
							dodicator.enabled = false;
							//indicator.text = ".";
						}
			

		if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
		{
			if (hit.collider.tag == "Door")
			{
				//indicator.text = "����� �";
				indicator.enabled = true;
				if (Input.GetKeyDown(KeyCode.E))
				{
					hit.collider.GetComponent<Item>().Interaction();
					if (hit.collider.CompareTag("Door"))
					{
						hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
					}
				}
			}
			else
			{
				indicator.enabled = false;
				//indicator.text = ".";
			}
		}
		else
		{
			indicator.enabled = false;
			//indicator.text = ".";
		}

	}
}
